using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCTut.Models;

namespace MVCTut.Data
{
    public class MVCTutContext : DbContext
    {
        public MVCTutContext (DbContextOptions<MVCTutContext> options)
            : base(options)
        {
        }

        public DbSet<MVCTut.Models.Movie> Movie { get; set; }
    }
}
