using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Common;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Areas.Admin.Pages.GraphicsCards
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class DeleteModel : PageModel
    {
        private readonly PCBuilder.Data.PCBuilderContext _context;

        public DeleteModel(PCBuilder.Data.PCBuilderContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GraphicsCard = await _context.GraphicsCards.FindAsync(id);

            if (GraphicsCard != null)
            {
                _context.GraphicsCards.Remove(GraphicsCard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
