﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Service = await _context.Service.ToListAsync();
        }
    }
}
