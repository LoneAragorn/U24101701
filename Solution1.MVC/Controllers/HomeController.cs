using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solution1.Data;

namespace Solution1.MVC.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Bookings()
        {
            return View(_repo.Bookings);
        }

        [HttpGet]
        public ActionResult NewBooking()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBooking(Booking b) //Auto binding från Name och Price
        {
            _repo.Add(b);
            return RedirectToAction("Bookings");
        }
    }
}