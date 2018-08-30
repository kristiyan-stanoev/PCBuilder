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
    public class MemoryController : BaseController
    {
        public MemoryController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(MemoryBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.Memory.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }
            var memory = mapper.Map<Memory>(model);

            context.Memory.Add(memory);
            context.SaveChanges();

            return RedirectToAction("Details", "Memory", new { area = "", id = memory.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var memory = context.Memory.FirstOrDefault(p => p.Id == id);

            if (memory == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MemoryBindingModel>(memory);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, MemoryBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var memory = context.Memory.FirstOrDefault(p => p.Id == id);

            if (memory == null)
            {
                return NotFound();
            }

            MapProperties(memory, model);

            context.SaveChanges();

            return RedirectToAction("Details", "Memory", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var memory = context.Memory.FirstOrDefault(p => p.Id == id);

            if (memory == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MemoryViewModel>(memory);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var memory = context.Memory.FirstOrDefault(p => p.Id == id);

            if (memory == null)
            {
                return NotFound();
            }

            context.Memory.Remove(memory);
            context.SaveChanges();

            return RedirectToAction("Index", "Memory", new { area = "" });
        }
    }
}