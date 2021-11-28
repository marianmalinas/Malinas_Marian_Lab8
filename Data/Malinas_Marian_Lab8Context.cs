using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Malinas_Marian_Lab8.Models;

namespace Malinas_Marian_Lab8.Data
{
    public class Malinas_Marian_Lab8Context : DbContext
    {
        public Malinas_Marian_Lab8Context (DbContextOptions<Malinas_Marian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Malinas_Marian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Malinas_Marian_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
