using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCBuilder.Tests.Controllers.Admin.PowerSuppliesControllerTests
{
    [TestClass]
    public class EditTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private PowerSuppliesController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.controller = new PowerSuppliesController(dbContext, mapper);
        }

        [TestMethod]
        public void PowerSupplieController_WithValidModel_ShouldEditPowerSupplyAndAddToDb()
        {
            var dbPowerSupply = new PowerSupply()
            {
                Connector = "24 pin",
                Effectiveness = 90,
                Manufacturer = "Connectors",
                ModelName = "Cnt5S",
                NumberOfCoolingVents = 8,
                Pfc = "PFC",
                Power = 800,
                Price = 300
            };

            dbContext.PowerSupplies.Add(dbPowerSupply);
            dbContext.SaveChanges();

            var powerSupplyModel = new PowerSupplyBindingModel()
            {
                Connector = "12 pin",
                Effectiveness = 80,
                Manufacturer = "ConnectorsInc",
                ModelName = "Cnt5SP+",
                NumberOfCoolingVents = 4,
                Pfc = "PFCMAX",
                Power = 600,
                Price = 500
            };

            var powerSupply = dbContext.PowerSupplies.First();

            controller.Edit(powerSupply.Id, powerSupplyModel);

            var dbEditedPowerSupply = dbContext.PowerSupplies.First();

            Assert.IsNotNull(dbEditedPowerSupply);
            Assert.AreEqual(dbEditedPowerSupply.Connector, powerSupplyModel.Connector);
            Assert.AreEqual(dbEditedPowerSupply.Effectiveness, powerSupplyModel.Effectiveness);
            Assert.AreEqual(dbEditedPowerSupply.Manufacturer, powerSupplyModel.Manufacturer);
            Assert.AreEqual(dbEditedPowerSupply.ModelName, powerSupplyModel.ModelName);
            Assert.AreEqual(dbEditedPowerSupply.NumberOfCoolingVents, powerSupplyModel.NumberOfCoolingVents);
            Assert.AreEqual(dbEditedPowerSupply.Pfc, powerSupplyModel.Pfc);
            Assert.AreEqual(dbEditedPowerSupply.Power, powerSupplyModel.Power);
            Assert.AreEqual(dbEditedPowerSupply.Price, powerSupplyModel.Price);
        }
    }
}
