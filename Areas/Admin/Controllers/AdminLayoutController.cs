using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
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

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var incomingEmails = context.Messages.Where(x => x.ReceiverMail == email).ToList();

            return PartialView(incomingEmails);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}