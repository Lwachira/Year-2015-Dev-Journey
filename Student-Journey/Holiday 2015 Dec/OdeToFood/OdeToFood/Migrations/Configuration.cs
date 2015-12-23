namespace OdeToFood.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Models.Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Models.Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Models.Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews = new List<Models.ResturantReview> { new Models.ResturantReview { Rating = 9, Body = "Great food!",ReviewerName="Lincoln" }
                    }
                });


            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Models.Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
                    
            }
        }
    }
}
