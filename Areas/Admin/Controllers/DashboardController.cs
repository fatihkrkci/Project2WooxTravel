using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            var adminCount = context.Admins.ToList().Count();
            ViewBag.AdminCount = adminCount;
            
            var categoryCount = context.Categories.ToList().Count();
            ViewBag.CategoryCount = categoryCount;
            
            var destinationCount = context.Destinations.ToList().Count();
            ViewBag.DestinationCount = destinationCount;
            
            var messageCount = context.Messages.ToList().Count();
            ViewBag.MessageCount = messageCount;
            
            var reservationCount = context.Reservations.ToList().Count();
            ViewBag.ReservationCount = reservationCount;

            var inTurkeyDestinationCount = context.Destinations.Where(x => x.Country == "Türkiye").Count();
            ViewBag.InTurkeyDestinationCount = inTurkeyDestinationCount;
            
            var internationalDestinationCount = context.Destinations.Where(x => x.Country != "Türkiye").Count();
            ViewBag.InternationalDestinationCount = internationalDestinationCount;

            var moreThan5DaysDestinationCount = context.Destinations.Where(x => x.DayNight > 5).Count();
            ViewBag.MoreThan5DaysDestinationCount = moreThan5DaysDestinationCount;

            var lessThan5DaysDestinationCount = context.Destinations.Where(x => x.DayNight <= 5).Count();
            ViewBag.LessThan5DaysDestinationCount = lessThan5DaysDestinationCount;

            var subjectThanksMessageCount = context.Messages.Where(x => x.Subject == "Teşekkür").Count();
            ViewBag.SubjectThanksMessageCount = subjectThanksMessageCount;

            var subjectComplaintMessageCount = context.Messages.Where(x => x.Subject == "Şikayet").Count();
            ViewBag.SubjectComplaintMessageCount = subjectComplaintMessageCount;

            var people2ReservationCount = context.Reservations.Where(x => x.PersonCount == 2).Count();
            ViewBag.People2ReservationCount = people2ReservationCount;

            return View();
        }
    }
}