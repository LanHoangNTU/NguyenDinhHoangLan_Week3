﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDinhHoangLan_BaiTap5.Models;

namespace NguyenDinhHoangLan_BaiTap5.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Mail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Mail(MailInfo model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(model.From);
            mail.To.Add(model.To);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return View("Mail");
        }
    }
}