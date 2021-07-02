using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebPro.Models;

namespace SalesWebPro.Data
{
    public class SalesWebProContext : DbContext
    {
        public SalesWebProContext (DbContextOptions<SalesWebProContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebPro.Models.Departament> Departament { get; set; }
    }
}
