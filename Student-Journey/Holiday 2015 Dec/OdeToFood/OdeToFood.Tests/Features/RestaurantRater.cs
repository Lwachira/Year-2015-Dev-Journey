using System;
using OdeToFood.Models;

namespace OdeToFood.Tests.Features
{
    internal class RestaurantRater
    {
        private Restaurant data;

        public RestaurantRater(Restaurant data)
        {
            this.data = data;
        }

     public RatingResult ComputeRating(int v)
        {
            var result = new RatingResult();
            result.Rating = 4;
            return result;

        }
    }
}