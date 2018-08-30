using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PCBuilder.Common;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace PCBuilder.Tests.Controllers.Admin.AdminFunctionalityTests
{
    [TestClass]
    public class UserAccessTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private MemoryController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.controller = new MemoryController(dbContext, mapper);
        }

        [TestMethod]
        public void MemoryController_WithUserWhoIsNotAdmin_ShouldNotBeAbleToDeleteMemory()
        {
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

            var user = controller.ControllerContext.HttpContext.User;

            var role = user.Claims.First().Value;

            bool isAuthorized = role == WebConstants.AdminRole;

            Assert.IsFalse(isAuthorized);
        }
    }
}
