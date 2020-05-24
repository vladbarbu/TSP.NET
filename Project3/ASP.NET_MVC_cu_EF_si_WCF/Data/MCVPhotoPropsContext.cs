using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_cu_EF_si_WCF.Data
{
    public class MCVPhotoPropsContext: DbContext
    {
        public MCVPhotoPropsContext(DbContextOptions<MCVPhotoPropsContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_MVC_cu_EF_si_WCF.Models.PhotoDTO> Photos { get; set; }
    }
}
