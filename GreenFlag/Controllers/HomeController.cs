using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return Json(new {success=true});
        }
	}
}