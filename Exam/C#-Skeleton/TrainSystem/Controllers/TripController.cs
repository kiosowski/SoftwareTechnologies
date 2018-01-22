namespace TrainSystem.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class TripController : Controller
    {

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var context = new TrainSystemDbContext())
            { 
                List<Trip> trains = context.Trips.ToList();
                return View(trains);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trip trip)
        {
            using (var context = new TrainSystemDbContext())
            {
                context.Trips.Add(trip);
                context.SaveChanges();

                return this.Redirect("/");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var context = new TrainSystemDbContext())
            {
                Trip tripForDb = context.Trips.Find(id);
                return View(tripForDb);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Trip trip)
        {
            using (var context = new TrainSystemDbContext())
            {
                Trip tripForDb = context.Trips.Find(id);
                tripForDb.Id = trip.Id;
                tripForDb.Origin = trip.Origin;
                context.SaveChanges();
                return Redirect("/");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var context = new TrainSystemDbContext())
            {
                Trip tripForDb = context.Trips.Find(id);
                if (tripForDb == null)
                {
                    return HttpNotFound();
                   
                }
                return View(tripForDb);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Trip tripModel)
        {
            using (var context = new TrainSystemDbContext())
            {
                Trip tripForDb = context.Trips.Find(id);
                
                if (tripForDb == null)
                {
                    return HttpNotFound();

                }
                context.Trips.Remove(tripForDb);
                context.SaveChanges();

                return Redirect("/");
            }
        }
    }
}