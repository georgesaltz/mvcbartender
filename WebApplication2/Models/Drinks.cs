using System;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class Drinks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class DrinkDBContext : DbContext
    {
        public DbSet<Drinks> Drinks { get; set; }
    }
}