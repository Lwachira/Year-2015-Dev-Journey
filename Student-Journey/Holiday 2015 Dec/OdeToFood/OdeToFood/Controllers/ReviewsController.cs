using odetofood.models;
using OdeToFood.Models;
using system;
using system.collections.generic;
using system.linq;
using system.web;
using system.web.mvc;
using System.Web.Mvc;

namespace odetofood.controllers
{
    public class reviewscontroller : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        // get: reviews
        public ActionResult Index([Bind(Prefix ="id")]int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);

                   
            }

            return HttpNotFound("Error cant compute");
        }



        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}