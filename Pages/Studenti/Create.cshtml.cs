using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GrozaEsteraDaniela_proiect6.Data;
using GrozaEsteraDaniela_proiect6.Models;

namespace GrozaEsteraDaniela_proiect6.Pages.Studenti
{
    public class CreateModel : PageModel
    {
        private readonly GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context _context;

        public CreateModel(GrozaEsteraDaniela_proiect6.Data.GrozaEsteraDaniela_proiect6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Student == null || Student == null)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
