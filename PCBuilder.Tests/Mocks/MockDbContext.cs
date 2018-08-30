using Microsoft.EntityFrameworkCore;
using PCBuilder.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder.Tests.Mocks
{
    public static class MockDbContext
    {
        public static PCBuilderContext GetContext()
        {
            var options = new DbContextOptionsBuilder<PCBuilderContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;



            return new PCBuilderContext(options);
        }
    }
}
