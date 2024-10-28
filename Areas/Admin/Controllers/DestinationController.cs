using PagedList;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class DestinationController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult DestinationList(int page = 1)
        {
            // Tüm destinasyonları al ve sıralama ekle (örneğin DestinationId'ye göre)
            var values = context.Destinations
                .OrderBy(d => d.DestinationId); // Sıralama ekleniyor

            // Sayfalama: her sayfada 5 veri olacak şekilde
            int pageSize = 5;
            var pagedDestinations = values.ToPagedList(page, pageSize);

            return View(pagedDestinations);
        }

        public ActionResult CreateDestination()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDestination(Destination destination)
        {
            destination.CreatedAt = DateTime.Now;
            destination.Status = true;
            context.Destinations.Add(destination);
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }

        
        public ActionResult DeleteDestination(int id)
        {
            var value = context.Destinations.Find(id);
            context.Destinations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }

        [HttpGet]
        public ActionResult UpdateDestination(int id)
        {
            var value = context.Destinations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateDestination(Destination destination)
        {
            var value = context.Destinations.Find(destination.DestinationId);
            value.Description = destination.Description;
            value.City = destination.City;
            value.DayNight = destination.DayNight;
            value.Country = destination.Country;
            value.ImageUrl = destination.ImageUrl;
            value.Price = destination.Price;
            value.Title = destination.Title;
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }
    }
}