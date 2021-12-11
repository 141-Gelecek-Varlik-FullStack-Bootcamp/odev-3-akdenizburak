using CarFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarFinderDataAccess
{
    public class CarDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=VAIO\\SQLEXPRESS; Database=CarDb; Trusted_Connection=True;");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
