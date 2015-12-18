using OdeToFood.Models;
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

            return HttpNotFound();
        }



        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}