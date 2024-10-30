using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Line()
        {
            var messageSubjects = context.Messages.Select(m => m.Subject).Distinct().ToList();
            var messageCounts = context.Messages
                                        .GroupBy(m => m.Subject)
                                        .Select(g => g.Count())
                                        .ToList();

            if (messageSubjects == null || messageSubjects.Count == 0)
            {
                Console.WriteLine("MessageSubjects boş.");
            }
            if (messageCounts == null || messageCounts.Count == 0)
            {
                Console.WriteLine("MessageCounts boş.");
            }

            ViewBag.MessageSubjects = messageSubjects;
            ViewBag.MessageCounts = messageCounts;

            return View();
        }

        public ActionResult Bar()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            var reservations = context.Reservations
                .Where(r => r.ReservationStartDate.Month == currentMonth && r.ReservationStartDate.Year == currentYear)
                .ToList();

            var personCounts = new int[DateTime.DaysInMonth(currentYear, currentMonth)];

            foreach (var reservation in reservations)
            {
                var day = reservation.ReservationStartDate.Day;
                personCounts[day - 1] += reservation.PersonCount;
            }

            ViewBag.PersonCounts = personCounts;
            ViewBag.Days = Enumerable.Range(1, personCounts.Length).ToList();
            return View();
        }

        public ActionResult Pie()
        {
            var destinations = context.Destinations
                .Select(d => new
                {
                    Title = d.Title,
                    Capacity = d.Capacity
                })
                .ToList();

            ViewBag.DestinationTitles = destinations.Select(d => d.Title).ToList();
            ViewBag.DestinationCapacities = destinations.Select(d => d.Capacity).ToList();

            return View();
        }

        public ActionResult Doughnut()
        {
            var destinations = context.Destinations
                .Select(d => new
                {
                    Title = d.Title,
                    Price = d.Price
                })
                .ToList();

            ViewBag.DestinationTitles = destinations.Select(d => d.Title).ToList();
            ViewBag.DestinationPrices = destinations.Select(d => d.Price).ToList();

            return View();
        }
    }
}