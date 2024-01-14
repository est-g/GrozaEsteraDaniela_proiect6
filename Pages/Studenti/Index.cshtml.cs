using System;
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
    public class IndexModel : PageModel
    {
        private readonly GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context _context;

        public IndexModel(GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
