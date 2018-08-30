using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Controllers
{
    public class ProcessorsController : BaseController
    {
        public ProcessorsController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(ProcessorBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.Processors.Any(p => p.ModelName == model.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToAction("Create");
            }
            var processor = mapper.Map<Processor>(model);

            context.Processors.Add(processor);
            context.SaveChanges();

            return RedirectToAction("Details", "Processors", new { area = "", id = processor.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var processor = context.Processors.FirstOrDefault(p => p.Id == id);

            if (processor == null)
            {
                return NotFound();
            }

            var model = mapper.Map<ProcessorBindingModel>(processor);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, ProcessorBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var processor = context.Processors.FirstOrDefault(p => p.Id == id);

            if (processor == null)
            {
                return NotFound();
            }

            MapProperties(processor, model);

            //var propertiesOfEntity = processor.GetType().GetProperties();

            //var propertiesOfModel = model.GetType().GetProperties();

            //foreach (var propertyModel in propertiesOfModel)
            //{
            //    foreach (var propertyEntity in propertiesOfEntity)
            //    {
            //        if (propertyEntity.Name == propertyModel.Name)
            //        {
            //            propertyEntity.SetValue(processor, propertyModel.GetValue(model));
            //            break;
            //        }
            //    }

            //}

            context.SaveChanges();

            return RedirectToAction("Details", "Processors", new { area = "", id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var processor = context.Processors.FirstOrDefault(p => p.Id == id);

            if (processor == null)
            {
                return NotFound();
            }

            var model = mapper.Map<ProcessorViewModel>(processor);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var processor = context.Processors.FirstOrDefault(p => p.Id == id);

            if (processor == null)
            {
                return NotFound();
            }

            context.Processors.Remove(processor);
            context.SaveChanges();

            return RedirectToAction("Index", "Processors", new { area = "" });
        }
    }
}