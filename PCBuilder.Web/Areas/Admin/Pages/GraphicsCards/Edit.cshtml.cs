using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Common;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Pages.GraphicsCards
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class EditModel : PageModel
    {
        private readonly PCBuilder.Data.PCBuilderContext _context;

        public EditModel(PCBuilder.Data.PCBuilderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GraphicsCard GraphicsCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GraphicsCard = await _context.GraphicsCards.FirstOrDefaultAsync(m => m.Id == id);

            if (GraphicsCard == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GraphicsCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GraphicsCardExists(GraphicsCard.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GraphicsCardExists(int id)
        {
            return _context.GraphicsCards.Any(e => e.Id == id);
        }
    }
}
