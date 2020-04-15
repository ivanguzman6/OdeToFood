using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OdeToFood.Data.Models;
using System.Data.Entity;

namespace OdeToFood.Data.Services
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
