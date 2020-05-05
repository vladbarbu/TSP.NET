using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Barbu_Vlad_Rp.Models;

namespace Asp_Barbu_Vlad_Rp.Data
{
    public class Asp_Barbu_Vlad_RpContext : DbContext
    {
        public Asp_Barbu_Vlad_RpContext (DbContextOptions<Asp_Barbu_Vlad_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Barbu_Vlad_Rp.Models.Movie> Movie { get; set; }
    }
}
