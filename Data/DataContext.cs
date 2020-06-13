using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport_Server.Models;

namespace Transport_Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }
        
        
        public DbSet<Car> Cars { get; set; }
        
        public DbSet<Service> Services { get; set; }

        public DbSet<CarService> CarServices { get; set; }
        
        public DbSet<CarServicePart> CarServiceParts { get; set; }
        
        public DbSet<Mechanic> Mechanics { get; set; }

        public DbSet<Part> Parts { get; set; }
    }
}
