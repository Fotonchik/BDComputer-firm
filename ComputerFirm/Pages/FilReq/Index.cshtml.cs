using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Computerfirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComputerFirm.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }
        //public IList<Staff> Staff { get; set; }
        public IList<SelectListItem> SelPosition { get; set; }

        public IActionResult OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                new SelectListItem {
                    Value = p.ID.ToString(),
                    Text = p.NamePosition
                }).ToList();
            return Page();
        }
    }
}
