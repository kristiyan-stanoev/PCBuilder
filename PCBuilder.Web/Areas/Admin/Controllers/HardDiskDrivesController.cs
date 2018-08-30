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
    public class HardDiskDrivesController : BaseController
    {
        public HardDiskDrivesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(HardDiskDriveBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.HardDiskDrives.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }

            var hardDiskDrive = mapper.Map<HardDiskDrive>(model);

            context.HardDiskDrives.Add(hardDiskDrive);
            context.SaveChanges();

            return RedirectToAction("Details", "HardDiskDrives", new { area = "", id = hardDiskDrive.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var hardDiskDrive = context.HardDiskDrives.FirstOrDefault(p => p.Id == id);

            if (hardDiskDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<HardDiskDriveBindingModel>(hardDiskDrive);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, HardDiskDriveBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var hardDiskDrive = context.HardDiskDrives.FirstOrDefault(p => p.Id == id);

            if (hardDiskDrive == null)
            {
                return NotFound();
            }

            MapProperties(hardDiskDrive, model);

            context.SaveChanges();

            return RedirectToAction("Details", "HardDiskDrives", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var hardDiskDrive = context.HardDiskDrives.FirstOrDefault(p => p.Id == id);

            if (hardDiskDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<HardDiskDriveViewModel>(hardDiskDrive);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var hardDiskDrive = context.HardDiskDrives.FirstOrDefault(p => p.Id == id);

            if (hardDiskDrive == null)
            {
                return NotFound();
            }

            context.HardDiskDrives.Remove(hardDiskDrive);
            context.SaveChanges();

            return RedirectToAction("Index", "HardDiskDrives", new { area = "" });
        }
    }
}