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
    public class MotherboardsController : BaseController
    {
        public MotherboardsController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(MotherboardBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.Motherboards.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }

            var pcMotherboard = mapper.Map<Motherboard>(model);

            context.Motherboards.Add(pcMotherboard);
            context.SaveChanges();

            return RedirectToAction("Details", "Motherboards", new { area = "", id = pcMotherboard.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pcMotherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

            if (pcMotherboard == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MotherboardBindingModel>(pcMotherboard);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, MotherboardBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var pcMotherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

            if (pcMotherboard == null)
            {
                return NotFound();
            }

            MapProperties(pcMotherboard, model);

            context.SaveChanges();

            return RedirectToAction("Details", "Motherboards", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pcMotherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

            if (pcMotherboard == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MotherboardViewModel>(pcMotherboard);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var pcMotherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

            if (pcMotherboard == null)
            {
                return NotFound();
            }

            context.Motherboards.Remove(pcMotherboard);
            context.SaveChanges();

            return RedirectToAction("Index", "Motherboards", new { area = "" });
        }
    }
}