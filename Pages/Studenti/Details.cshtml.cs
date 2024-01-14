﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrozaEsteraDaniela_proiect6.Data;
using GrozaEsteraDaniela_proiect6.Models;

namespace GrozaEsteraDaniela_proiect6.Pages.Studenti
{
    public class DetailsModel : PageModel
    {
        private readonly GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context _context;

        public DetailsModel(GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context context)
        {
            _context = context;
        }

      public Student Student { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }
    }
}
