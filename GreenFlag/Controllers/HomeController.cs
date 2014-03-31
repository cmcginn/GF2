using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenFlag.Services;

namespace GreenFlag.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Contact()
        {
            var frm = Request.Form;
            bool success = false;
            try
            {
                var name = Request.Form["name"].Trim();
                var email = Request.Form["email"].Trim();
                var comments = Request.Form["comments"].Trim();
                var phone = String.IsNullOrEmpty(Request.Form["phone"]) ? "" : Request.Form["phone"].Trim();
                var service = new EmailService();
                success = service.SendContactSubmission(email, name, comments, phone);
            }
            catch
            {
                //swallow
            }
            return Json(new {success=success});
        }
	}
}