using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PCBuilder.Common;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Pages.GraphicsCards
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class CreateModel : PageModel
    {
        private readonly PCBuilder.Data.PCBuilderContext context;

        public CreateModel(PCBuilder.Data.PCBuilderContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GraphicsCard GraphicsCard { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToPage("Create");
            }

            if (context.GraphicsCards.Any(p => p.ModelName == GraphicsCard.ModelName))
            {
                TempData["Error"] = "Model name already exists.";
                return RedirectToPage("Create");
            }

            context.GraphicsCards.Add(GraphicsCard);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}