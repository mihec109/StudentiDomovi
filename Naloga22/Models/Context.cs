using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Models
{
    public class Context : DbContext
    {
        public DbSet<Studenti> Books { get; set; }

    }
}
