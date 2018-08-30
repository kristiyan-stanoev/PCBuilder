using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Controllers
{
    [Area(WebConstants.AdminArea)]
    [Authorize(Roles = WebConstants.AdminRole)]
    public abstract class BaseController : Controller
    {
        protected PCBuilderContext context;
        protected IMapper mapper;

        public BaseController(PCBuilderContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public void MapProperties(object entity, object model)
        {
            var propertiesOfEntity = entity.GetType().GetProperties();

            var propertiesOfModel = model.GetType().GetProperties();

            foreach (var propertyModel in propertiesOfModel)
            {
                foreach (var propertyEntity in propertiesOfEntity)
                {
                    if (propertyEntity.Name == propertyModel.Name)
                    {
                        propertyEntity.SetValue(entity, propertyModel.GetValue(model));
                        break;
                    }
                }

            }
        }
    }
}