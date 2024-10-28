using Project2WooxTravel.Context;
using PagedList; // PagedList kütüphanesini ekleyin
using System.Linq;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult ReservationList(int page = 1)
        {
            // Sayfalama: her sayfada 10 rezervasyon olacak şekilde
            int pageSize = 5;
            var reservations = context.Reservations
                .OrderBy(r => r.ReservationId) // Sıralama ekleniyor
                .ToPagedList(page, pageSize);

            return View(reservations);
        }
    }
}
