using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenDinhHoangLan_BaiTap5.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Mail()
        {
            return View("../Mail/Mail");
        }

        public ActionResult Register()
        {
            return View("../Register/Index");
        }
        public ActionResult Banner()
        {
            return View("../Banner/Banner");
        }
    }
}