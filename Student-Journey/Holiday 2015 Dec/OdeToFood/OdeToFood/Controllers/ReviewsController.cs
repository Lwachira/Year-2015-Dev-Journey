using OdeToFood.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace odetofood.controllers
{
    public class reviewscontroller : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        // get: reviews
        public ActionResult Index([Bind(Prefix = "id")]int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);


            }

            return HttpNotFound();
        }




        [HttpPost]
        public ActionResult Create(ResturantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }


        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit([Bind(Exclude = "ReviewerName")]ResturantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return View(review);
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}