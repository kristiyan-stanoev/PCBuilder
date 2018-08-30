using AutoMapper;
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

namespace PCBuilder.Tests.Controllers.Admin.ProcessorsControllerTests
{
    [TestClass]
    public class CreateTests
    {
        private IMapper mapper;
        private PCBuilderContext dbContext;
        private ProcessorsController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.dbContext = MockDbContext.GetContext();
            this.controller = new ProcessorsController(dbContext, mapper);
        }

        [TestMethod]
        public void ProcessorsController_WithValidModel_ShouldCreateProcessorAndAddToDb()
        {
            var processorModel = new ProcessorBindingModel()
            {
                Architecture = "Cabi lake",
                Cache = 12,
                Frequency = 4,
                Manufacturer = "Antel",
                MaxMemorySize = 32,
                ModelName = "i3-7800",
                NumberOfCores = 6,
                Power = 200,
                Price = 350,
                Socket = "H65"
            };

            var processor = mapper.Map<Processor>(processorModel);

            processor.Id = 1;

            controller.Create(processorModel);

            var dbProcessor = dbContext.Processors.FirstOrDefault(p => p.ModelName == processor.ModelName);

            Assert.IsNotNull(dbProcessor);
            Assert.AreEqual(1, this.dbContext.Processors.Count());
            Assert.AreEqual(dbProcessor.ModelName, processor.ModelName);
            Assert.AreEqual(dbProcessor.Architecture, processor.Architecture);
            Assert.AreEqual(dbProcessor.Power, processor.Power);
            Assert.AreEqual(dbProcessor.Price, processor.Price);
            Assert.AreEqual(dbProcessor.Socket, processor.Socket);
            Assert.AreEqual(dbProcessor.Cache, processor.Cache);
            Assert.AreEqual(dbProcessor.Frequency, processor.Frequency);
            Assert.AreEqual(dbProcessor.MaxMemorySize, processor.MaxMemorySize);
            Assert.AreEqual(dbProcessor.Manufacturer, processor.Manufacturer);
            Assert.AreEqual(dbProcessor.NumberOfCores, processor.NumberOfCores);
        }
    }
}
