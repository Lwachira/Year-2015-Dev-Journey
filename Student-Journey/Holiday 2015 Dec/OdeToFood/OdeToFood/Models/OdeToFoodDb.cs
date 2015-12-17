using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    class OdeToFoodDb : DbContext
    {

        public OdeToFoodDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<ResturantReview> Reviews { get; set; }

    }
}
