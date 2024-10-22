using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Inbox()
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var incomingEmails = context.Messages.Where(x => x.ReceiverMail == email).ToList();

            return View(incomingEmails);
        }

        public ActionResult Sendbox()
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var sentEmails = context.Messages.Where(x => x.SenderMail == email).ToList();

            return View(sentEmails);
        }

        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            message.SenderMail = email;
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            context.Messages.Add(message);
            context.SaveChanges();

            return RedirectToAction("SendBox", "Message", new { area = "Admin" });
        }
    }
}