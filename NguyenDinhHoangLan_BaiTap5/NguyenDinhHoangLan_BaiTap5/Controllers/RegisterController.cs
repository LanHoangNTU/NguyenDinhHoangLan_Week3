using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDinhHoangLan_BaiTap5.Models;

namespace NguyenDinhHoangLan_BaiTap5.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmpModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            HttpPostedFileBase Avatar = Request.Files[0];
            if (Avatar.ContentLength > 0)
            {

                string postedFileName = System.IO.Path.GetFileName(Avatar.FileName);

                string path = Server.MapPath("/Images/") + postedFileName;
                Avatar.SaveAs(path);
                string fSave = Server.MapPath("/info.txt");
                string[] emInfo =
                    {model.EmpID,
                    model.Name,
                    model.DateOfBirth.ToShortDateString(),
                    model.Email,
                    model.Password,
                    model.Department,
                    postedFileName
                };
                System.IO.File.WriteAllLines(fSave, emInfo);

                model.EmpID = emInfo[0];
                model.Name = emInfo[1];
                model.DateOfBirth = model.DateOfBirth;
                model.Email = emInfo[3];
                model.Password = emInfo[4];
                model.Department = emInfo[5];
                model.Avatar = "/Images/" + emInfo[6];
            }
            return View("Confirm", model);
        }
        public ActionResult Confirm(EmpModel emp)
        {
            return View(emp);
        }
    }
}