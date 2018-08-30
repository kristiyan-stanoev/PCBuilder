using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Controllers;

namespace PCBuilder.Tests.Controllers.BuildsControllerTests
{
    [TestClass]
    public class RateTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private UserManager<User> userManager;
        private BuildsController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.userManager = new UserManager<User>(new UserStore<User>(dbContext), null, null, null, null, null, null, null, null);
            this.controller = new BuildsController(dbContext, mapper, userManager);

            var users = new[]
   {
                new User() { Id = "111" },
                new User() { Id = "222" },
                new User() { Id = "333" },
                new User() { Id = "444" }
            };

            var mockUserStore = new Mock<IUserStore<User>>();
            var mockUserManager = new Mock<UserManager<User>>(
                mockUserStore.Object, null, null, null, null, null, null, null, null);
            mockUserManager.Setup(um => um.GetUserAsync(null))
                .ReturnsAsync(users[1]);

            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext()
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new[]
                       {
                          new Claim(ClaimTypes.Role, "User")

                      }))
                }
            };

            var tempData = new TempDataDictionary(controller.HttpContext, Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;
        }

        [TestMethod]
        public void RateController_WithInvalidUserId_ShouldReturnNotFoundResult()
        {
            var result = controller.Rate(5, "Invalid Id", "Invalid Id2");

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void RateController_WithInvalidRate_ShouldReturnRedirectAndProperMessage()
        {
            var result = controller.Rate(11, "Invalid Id", "Builder");

            var message = controller.TempData["Error"];

            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
            Assert.AreEqual("Invalid rate!", message);
        }

        [TestMethod]
        public void RateController_WithUserIdSameAsBuilder_ShouldReturnRedirectAndProperMessage()
        {
            controller.User.AddIdentity(new ClaimsIdentity(new[] 
            {
                new Claim(ClaimTypes.Name, "User")
            }));

            var result = controller.Rate(10, "Random Id", "User");
            var message = controller.TempData["Error"];

            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
            Assert.AreEqual("You cannot rate your own build!", message);
        }

    }
}
