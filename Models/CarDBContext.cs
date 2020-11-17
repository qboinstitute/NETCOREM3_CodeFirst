using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREM3_CodeFirst.Models
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {


        }

        public DbSet<Vehiculo> Vehiculos { get; set; } 


    }
}
