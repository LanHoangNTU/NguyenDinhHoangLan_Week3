using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDinhHoangLan_BaiTap5.Models;

namespace NguyenDinhHoangLan_BaiTap5.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner
        public ActionResult Banner()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Banner(BannerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            HttpPostedFileBase Banner = Request.Files[0];
            if (Banner.ContentLength > 0)
            {
                string fileName = System.IO.Path.GetFileName(Banner.FileName);
                var path = Server.MapPath("/Images/" + fileName);
                Banner.SaveAs(path);
                string fSave = Server.MapPath("/banner.txt");
                System.IO.File.WriteAllText(fSave, fileName);

                ViewBag.image = "/Images/" + fileName;
            }
            return View();
        }
    }
}