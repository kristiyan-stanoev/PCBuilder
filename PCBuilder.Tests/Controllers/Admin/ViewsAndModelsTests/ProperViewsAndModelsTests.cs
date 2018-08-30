using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PCBuilder.Tests.Controllers.Admin.ViewsAndModelsTests
{
    [TestClass]
    public class ProperViewsAndModelsTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private PowerSuppliesController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            var options = new DbContextOptionsBuilder<PCBuilderContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;

            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = new PCBuilderContext(options);
            this.controller = new PowerSuppliesController(dbContext, mapper);
        }

        [TestMethod]
        public void PowerSuppliesController_ShouldReturnViewResultWithPowerSupplyBindingModel()
        {
            var dbPowerSupply = new PowerSupply()
            {
                Connector = "36 pin",
                Effectiveness = 99,
                Manufacturer = "ConnectorsInc",
                ModelName = "con",
                NumberOfCoolingVents = 2,
                Pfc = "pcf",
                Power = 1000,
                Price = 1500
            };

            dbContext.PowerSupplies.Add(dbPowerSupply);
            dbContext.SaveChanges();

            var id = dbContext.PowerSupplies.First().Id;

            var result = this.controller.Edit(id);

            Assert.IsInstanceOfType(result, typeof(ViewResult));

            var resultViewModel = (result as ViewResult).Model;

            Assert.IsInstanceOfType(resultViewModel, typeof(PowerSupplyBindingModel));
        }
    }
}
