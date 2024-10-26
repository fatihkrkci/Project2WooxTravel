using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialBanner()
        {
            var last4Destination = context.Destinations.OrderByDescending(d => d.DestinationId).Take(4).ToList();
            return PartialView(last4Destination);
        }

        public PartialViewResult PartialCountry(int page = 1)
        {
            int pageSize = 3;
            var values = context.Destinations
                                .OrderByDescending(d => d.DestinationId)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = Math.Ceiling((double)context.Destinations.Count() / pageSize);

            return PartialView(values);
        }

        public ActionResult DestinationDetail(int id)
        {
            var destination = context.Destinations.Find(id);
            return View(destination);
        }

        [HttpGet]
        public PartialViewResult PartialReservationModal()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservationModal(Reservation reservation)
        {
            reservation.CreatedAt = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();

            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}