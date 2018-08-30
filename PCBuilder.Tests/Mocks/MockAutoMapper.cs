using AutoMapper;
using PCBuilder.Web.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder.Tests.Mocks
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
        }

        public static IMapper GetAutoMapper() => Mapper.Instance;
    }
}
