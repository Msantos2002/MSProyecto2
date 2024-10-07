using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSProyecto2.Models;

    public class MSProyecto2Context : DbContext
    {
        public MSProyecto2Context (DbContextOptions<MSProyecto2Context> options)
            : base(options)
        {
        }

        public DbSet<MSProyecto2.Models.Burger> Burger { get; set; } = default!;
    }
