using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCBuilder.Tests.Controllers.SolidStateDrivesControllerTests
{
    [TestClass]
    public class DetailsTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private SolidStateDrivesController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.controller = new SolidStateDrivesController(dbContext, mapper);
        }

        [TestMethod]
        public void SolidStateDrivesController_WithValidId_ShouldReturnDetailsOfEntityByGivenId()
        {
            var dbSsd = new SolidStateDrive()
            {
                Interface = "Sata 3",
                Manufacturer = "SSDs",
                MemoryCapacity = 256,
                ModelName = "PowerfulSSD",
                Price = 300,
                ReadSpeed = 1000,
                WriteSpeed = 1000
            };

            dbContext.SolidStateDrives.Add(dbSsd);
            dbContext.SaveChanges();

            var dbSsdModel = Mapper.Map<SolidStateDriveViewModel>(dbContext.SolidStateDrives.First());

            var result = this.controller.Details(1);

            var resultView = result as ViewResult;

            var ssdModel = (SolidStateDriveViewModel)resultView.Model;

            //Property ModelName is unique and there is no need to check every property explicitly.
            Assert.AreEqual(dbSsdModel.ModelName, ssdModel.ModelName);
            Assert.AreEqual(dbSsdModel.Interface, ssdModel.Interface);
            Assert.AreEqual(dbSsdModel.Manufacturer, ssdModel.Manufacturer);
            Assert.AreEqual(dbSsdModel.MemoryCapacity, ssdModel.MemoryCapacity);
            Assert.AreEqual(dbSsdModel.Price, ssdModel.Price);
            Assert.AreEqual(dbSsdModel.ReadSpeed, ssdModel.ReadSpeed);
            Assert.AreEqual(dbSsdModel.WriteSpeed, ssdModel.WriteSpeed);

            //var modelMotherboards = Mapper.Map<IEnumerable<MotherboardViewModel>>(motherboards);

            //var result = this.controller.Index();

            //var resultView = result as ViewResult;

            //Assert.IsInstanceOfType(resultView.Model, typeof(IEnumerable<MotherboardViewModel>));

            //CollectionAssert.AreEqual(modelMotherboards as List<MotherboardViewModel>, resultView.Model as List<MotherboardViewModel>);

        }
    }
}
