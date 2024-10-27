using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Project2WooxTravel.Controllers
{
    public class LoginController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["user"] = values.Username;

                // Başarılı giriş için herhangi bir bildirim yok
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            else
            {
                // Hatalı giriş için bir flag
                ViewBag.AlertType = "error";
                ViewBag.AlertMessage = "Giriş bilgileri hatalı. Tekrar deneyin.";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Index", "Login");
        }
    }
}
