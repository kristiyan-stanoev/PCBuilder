using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCBuilder.Common;
using PCBuilder.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCBuilder.Tests.Controllers.Admin.ProcessorsControllerTests
{
    [TestClass]
    public class ProcessorsControllerAdminAccessTests
    {
        [TestMethod]
        public void ProcessorsControllerInAdminArea_ShouldHaveAdminAttribute()
        {
            var area = typeof(ProcessorsController)
                .GetCustomAttributes(true)
                .FirstOrDefault(attr => attr is AreaAttribute) as AreaAttribute;

            Assert.IsNotNull(area);
            Assert.AreEqual(WebConstants.AdminArea, area.RouteValue);
        }
    }
}
