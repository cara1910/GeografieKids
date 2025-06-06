using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeografieKids.Models;

namespace GeografieKids.Controllers
{
    public class SelectareTestController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["User"] == null)
                return RedirectToAction("Index", "Login");

            return View();
        }

        [HttpPost]
        public ActionResult Index(string test)
        {
            Session["TipTest"] = test;
            return RedirectToAction("Index", "SelectareContinent");
        }
    }
}