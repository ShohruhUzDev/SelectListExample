using Microsoft.EntityFrameworkCore;
using SelectListExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListExample.Data
{
    public class SelectListDbContext:DbContext
    {
        public SelectListDbContext(DbContextOptions<SelectListDbContext>options):base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cityies { get; set; }
    }
}
