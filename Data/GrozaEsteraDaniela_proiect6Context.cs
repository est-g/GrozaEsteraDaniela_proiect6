using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrozaEsteraDaniela_proiect6.Models;

namespace GrozaEsteraDaniela_proiect6.Data
{
    public class GrozaEsteraDaniela_proiect6Context : DbContext
    {
        public GrozaEsteraDaniela_proiect6Context (DbContextOptions<GrozaEsteraDaniela_proiect6Context> options)
            : base(options)
        {
        }

        public DbSet<GrozaEsteraDaniela_proiect6.Models.Student> Student { get; set; } = default!;
    }
}
