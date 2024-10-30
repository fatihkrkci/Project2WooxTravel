﻿using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using PagedList;
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

        public ActionResult Inbox(int? page)
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var incomingEmails = context.Messages.Where(x => x.ReceiverMail == email).ToList();

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(incomingEmails.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Sendbox(int? page)
        {
            var username = Session["user"];
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var sentEmails = context.Messages.Where(x => x.SenderMail == email).ToList();

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(sentEmails.ToPagedList(pageNumber, pageSize));
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

        public JsonResult GetMessageDetail(int id)
        {
            var message = context.Messages.Find(id);
            if (message != null)
            {
                return Json(new
                {
                    senderMail = message.SenderMail,
                    receiverMail = message.ReceiverMail,
                    subject = message.Subject,
                    sendDate = message.SendDate.ToString("dd.MM.yyyy HH:mm"),
                    content = message.Content
                }, JsonRequestBehavior.AllowGet);
            }
            return Json(null);
        }
    }
}
