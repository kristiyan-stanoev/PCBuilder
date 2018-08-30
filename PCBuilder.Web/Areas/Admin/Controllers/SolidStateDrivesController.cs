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
    public class SolidStateDrivesController : BaseController
    {
        public SolidStateDrivesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(SolidStateDriveBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.SolidStateDrives.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }
            var solidStateDrive = mapper.Map<SolidStateDrive>(model);

            context.SolidStateDrives.Add(solidStateDrive);
            context.SaveChanges();

            return RedirectToAction("Details", "SolidStateDrives", new { area = "", id = solidStateDrive.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var solidStateDrive = context.SolidStateDrives.FirstOrDefault(p => p.Id == id);

            if (solidStateDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<SolidStateDriveBindingModel>(solidStateDrive);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, SolidStateDriveBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var solidStateDrive = context.SolidStateDrives.FirstOrDefault(p => p.Id == id);

            if (solidStateDrive == null)
            {
                return NotFound();
            }

            MapProperties(solidStateDrive, model);

            context.SaveChanges();

            return RedirectToAction("Details", "SolidStateDrives", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var solidStateDrive = context.SolidStateDrives.FirstOrDefault(p => p.Id == id);

            if (solidStateDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<SolidStateDriveViewModel>(solidStateDrive);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var solidStateDrive = context.SolidStateDrives.FirstOrDefault(p => p.Id == id);

            if (solidStateDrive == null)
            {
                return NotFound();
            }

            context.SolidStateDrives.Remove(solidStateDrive);
            context.SaveChanges();

            return RedirectToAction("Index", "SolidStateDrives", new { area = "" });
        }
    }
}