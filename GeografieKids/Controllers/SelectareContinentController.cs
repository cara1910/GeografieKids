using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeografieKids.Controllers
{
    public class SelectareContinentController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["User"] == null || Session["TipTest"] == null)
                return RedirectToAction("Index", "Login");

            return View();
        }

        [HttpPost]
        public ActionResult Index(string continent)
        {
            Session["Continent"] = continent;
            return RedirectToAction("StartTest", "Test");
        }
    }
}