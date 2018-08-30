using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;
using PCBuilder.Tests.Mocks;
using PCBuilder.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Tests.Controllers.MotherboardsControllerTests
{
    [TestClass]
    public class IndexTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private MotherboardsController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.controller = new MotherboardsController(dbContext, mapper);
        }

        [TestMethod]
        public void MotherboardsController_WithValidEntities_ShouldReturnAllMotherboardsFromDb()
        {
            var motherboard1 = new Motherboard()
            {
                Chipset = "SHJ",
                FormFactor = "ATX",
                GraphicsCardSocketNumber = "GCS",
                HDDInterface = "SATA 3",
                Manufacturer = "MotherboardsInc",
                MaxMemory = 32,
                MemorySocketNumber = "JFD",
                MemoryType = "DDR3",
                ModelName = "BIGBOSS",
                NumberOfMemorySlots = 6,
                PowerConnector = "24 pin",
                Price = 250,
                ProcessorSocketNumber = "SDF",
                SSDInterface = "USB"
            };

            var motherboard2 = new Motherboard()
            {
                Chipset = "KSJF",
                FormFactor = "ATX mini",
                GraphicsCardSocketNumber = "GCS",
                HDDInterface = "SATA 3",
                Manufacturer = "MotherboardsInc",
                MaxMemory = 64,
                MemorySocketNumber = "JFD",
                MemoryType = "DDR3",
                ModelName = "SMALLBOSS",
                NumberOfMemorySlots = 6,
                PowerConnector = "24 pin",
                Price = 250,
                ProcessorSocketNumber = "SDF",
                SSDInterface = "PCIe"
            };

            dbContext.Motherboards.Add(motherboard1);
            dbContext.Motherboards.Add(motherboard2);
            dbContext.SaveChanges();

            var motherboards = dbContext.Motherboards as IEnumerable<Motherboard>;

            var modelMotherboards = Mapper.Map<List<MotherboardViewModel>>(motherboards);

            var propertiesOfModel = modelMotherboards.First().GetType().GetProperties();

            var result = this.controller.Index();

            var resultView = result as ViewResult;
            bool asd = Equals(modelMotherboards.First(), (resultView.Model as List<MotherboardViewModel>).First());

            var modelCollection = (List<MotherboardViewModel>)resultView.Model;

            //var propertiesOfOutput = modelCollection.

            //Property ModelName is unique and there is no need to check every property explicitly.
            Assert.AreEqual(modelMotherboards.First().ModelName, modelCollection.First().ModelName);
            Assert.AreEqual(modelMotherboards.First().MemoryType, modelCollection.First().MemoryType);
            Assert.AreEqual(modelMotherboards.First().MemorySocketNumber, modelCollection.First().MemorySocketNumber);
            Assert.AreEqual(modelMotherboards.First().Chipset, modelCollection.First().Chipset);
            Assert.AreEqual(modelMotherboards.First().FormFactor, modelCollection.First().FormFactor);
            Assert.AreEqual(modelMotherboards.First().GraphicsCardSocketNumber, modelCollection.First().GraphicsCardSocketNumber);
            Assert.AreEqual(modelMotherboards.First().MaxMemory, modelCollection.First().MaxMemory);
            Assert.AreEqual(modelMotherboards.First().SSDInterface, modelCollection.First().SSDInterface);
            Assert.AreEqual(modelMotherboards.First().HDDInterface, modelCollection.First().HDDInterface);
            Assert.AreEqual(modelMotherboards.First().NumberOfMemorySlots, modelCollection.First().NumberOfMemorySlots);
            Assert.AreEqual(modelMotherboards.First().PowerConnector, modelCollection.First().PowerConnector);
            Assert.AreEqual(modelMotherboards.First().Price, modelCollection.First().Price);
            Assert.AreEqual(modelMotherboards.First().ProcessorSocketNumber, modelCollection.First().ProcessorSocketNumber);
            Assert.AreEqual(modelMotherboards.First().Manufacturer, modelCollection.First().Manufacturer);

            Assert.AreEqual(modelMotherboards.Skip(1).First().ModelName, modelCollection.Skip(1).First().ModelName);
            Assert.AreEqual(modelMotherboards.Skip(1).First().MemoryType, modelCollection.Skip(1).First().MemoryType);
            Assert.AreEqual(modelMotherboards.Skip(1).First().MemorySocketNumber, modelCollection.Skip(1).First().MemorySocketNumber);
            Assert.AreEqual(modelMotherboards.Skip(1).First().Chipset, modelCollection.Skip(1).First().Chipset);
            Assert.AreEqual(modelMotherboards.Skip(1).First().FormFactor, modelCollection.Skip(1).First().FormFactor);
            Assert.AreEqual(modelMotherboards.Skip(1).First().GraphicsCardSocketNumber, modelCollection.Skip(1).First().GraphicsCardSocketNumber);
            Assert.AreEqual(modelMotherboards.Skip(1).First().MaxMemory, modelCollection.Skip(1).First().MaxMemory);
            Assert.AreEqual(modelMotherboards.Skip(1).First().SSDInterface, modelCollection.Skip(1).First().SSDInterface);
            Assert.AreEqual(modelMotherboards.Skip(1).First().HDDInterface, modelCollection.Skip(1).First().HDDInterface);
            Assert.AreEqual(modelMotherboards.Skip(1).First().NumberOfMemorySlots, modelCollection.Skip(1).First().NumberOfMemorySlots);
            Assert.AreEqual(modelMotherboards.Skip(1).First().PowerConnector, modelCollection.Skip(1).First().PowerConnector);
            Assert.AreEqual(modelMotherboards.Skip(1).First().Price, modelCollection.Skip(1).First().Price);
            Assert.AreEqual(modelMotherboards.Skip(1).First().ProcessorSocketNumber, modelCollection.Skip(1).First().ProcessorSocketNumber);
            Assert.AreEqual(modelMotherboards.Skip(1).First().Manufacturer, modelCollection.Skip(1).First().Manufacturer);
        }

        [TestMethod]
        public void MotherboardsController_WithNoEntities_ShouldReturnNoModels()
        {
            var motherboardsInDbCount = this.dbContext.Motherboards.Count();

            var result = controller.Index();

            var resultView = result as ViewResult;

            var model = resultView.Model as IEnumerable<MotherboardViewModel>;

            Assert.AreEqual(motherboardsInDbCount, model.Count());
        }
    }
}
