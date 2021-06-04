using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cars.API.Models;

namespace Cars.API.Data
{
    public class CarsAPIContext : DbContext
    {
        public CarsAPIContext (DbContextOptions<CarsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Cars.API.Models.Car> Car { get; set; }
    }
}
