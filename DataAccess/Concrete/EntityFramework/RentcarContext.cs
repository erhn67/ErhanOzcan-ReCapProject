using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentcarContext : DbContext
    {
        // override on yaz OnConfiguring kısma tıkla
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-6MS7CV0 ; Database=Rentcar ; Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; } // benim Car nesnemi veri tabanındaki Cars ile bağla
        public DbSet<Color> Colors { get; set; }// benim Color nesnemi veri tabanındaki Colors ile bağla
        public DbSet<Brand> Brands { get; set; }//benim Brand nesnemi veri tabanındaki Brands ile bağla
    }
}
