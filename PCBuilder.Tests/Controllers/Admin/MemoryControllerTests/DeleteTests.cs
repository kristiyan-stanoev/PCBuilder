using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
using System.Threading.Tasks;

namespace PCBuilder.Tests.Controllers.Admin.MemoryControllerTests
{
    [TestClass]
    public class DeleteTests
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
        public void MemoryController_WithValidId_ShouldDeleteMemoryFromDb()
        {
            int id = 1;
            var dbMemory = new Memory()
            {
                Amount = 8,
                Frequency = 2444,
                Manufacturer = "Memories",
                ModelName = "Magma reaper",
                ModulesType = "SIMM",
                Price = 175,
                Socket = "PGHT",
                Type = "DDR4"
            };

            dbContext.Memory.Add(dbMemory);
            dbContext.SaveChanges();

            controller.DeleteConfirmed(id);

            var memory = dbContext.Memory.FirstOrDefault();

            var countOfEntities = dbContext.Memory.ToList().Count;

            Assert.IsNull(memory);
            Assert.AreEqual(0, countOfEntities);
        }

    }
}
