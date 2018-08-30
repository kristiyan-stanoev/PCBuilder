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
    public class CasesController : BaseController
    {
        public CasesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(CaseBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.Cases.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }

            var pcCase = mapper.Map<Case>(model);

            context.Cases.Add(pcCase);
            context.SaveChanges();

            return RedirectToAction("Details", "Cases", new { area = "", id = pcCase.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pcCase = context.Cases.FirstOrDefault(p => p.Id == id);

            if (pcCase == null)
            {
                return NotFound();
            }

            var model = mapper.Map<CaseBindingModel>(pcCase);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, CaseBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var pcCase = context.Cases.FirstOrDefault(p => p.Id == id);

            if (pcCase == null)
            {
                return NotFound();
            }

            MapProperties(pcCase, model);

            context.SaveChanges();

            return RedirectToAction("Details", "Cases", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pcCase = context.Cases.FirstOrDefault(p => p.Id == id);

            if (pcCase == null)
            {
                return NotFound();
            }

            var model = mapper.Map<CaseViewModel>(pcCase);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var pcCase = context.Cases.FirstOrDefault(p => p.Id == id);

            if (pcCase == null)
            {
                return NotFound();
            }

            context.Cases.Remove(pcCase);
            context.SaveChanges();

            return RedirectToAction("Index", "Cases", new { area = "" });
        }
    }
}