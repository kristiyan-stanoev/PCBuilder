using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Controllers
{
    public class PowerSuppliesController : BaseController
    {
        public PowerSuppliesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(PowerSupplyBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.PowerSupplies.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }
            var powerSupply = mapper.Map<PowerSupply>(model);

            context.PowerSupplies.Add(powerSupply);
            context.SaveChanges();

            return RedirectToAction("Details", "PowerSupplies", new { area = "", id = powerSupply.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var powerSupply = context.PowerSupplies.FirstOrDefault(p => p.Id == id);

            if (powerSupply == null)
            {
                return NotFound();
            }

            var model = mapper.Map<PowerSupplyBindingModel>(powerSupply);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, PowerSupplyBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var powerSupply = context.PowerSupplies.FirstOrDefault(p => p.Id == id);

            if (powerSupply == null)
            {
                return NotFound();
            }

            MapProperties(powerSupply, model);

            context.SaveChanges();

            return RedirectToAction("Details", "PowerSupplies", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var powerSupply = context.PowerSupplies.FirstOrDefault(p => p.Id == id);

            if (powerSupply == null)
            {
                return NotFound();
            }

            var model = mapper.Map<PowerSupplyViewModel>(powerSupply);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var powerSupply = context.PowerSupplies.FirstOrDefault(p => p.Id == id);

            if (powerSupply == null)
            {
                return NotFound();
            }

            context.PowerSupplies.Remove(powerSupply);
            context.SaveChanges();

            return RedirectToAction("Index", "PowerSupplies", new { area = "" });
        }
    }
}