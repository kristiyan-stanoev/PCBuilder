using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PCBuilder.Common;

namespace PCBuilder.Web.Areas.Admin.Pages.Parts
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class CreateModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}