using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
using GeografieKids.Models;

namespace GeografieKids.Controllers
{
    public class LoginController : Controller
    {
        private string xmlPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/utilizatori.xml");

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Username, string Parola)
        {
            var utilizatori = CitesteUtilizatoriDinXML();

            var user = utilizatori.FirstOrDefault(u => u.Username == Username && u.Parola == Parola);

            if (user != null)
            {
                Session["User"] = user.Username;
                return RedirectToAction("Index", "SelectareTest");
            }

            ViewBag.Eroare = "Username sau parolă incorecte!";
            return View();
        }

        private List<Utilizator> CitesteUtilizatoriDinXML()
        {
            var utilizatori = new List<Utilizator>();
            var doc = XDocument.Load(xmlPath);

            foreach (var elem in doc.Descendants("Utilizator"))
            {
                utilizatori.Add(new Utilizator
                {
                    Username = elem.Element("Username").Value,
                    Parola = elem.Element("Parola").Value
                });
            }

            return utilizatori;
        }
        [HttpPost]
        public ActionResult Register(string UsernameNou, string ParolaNoua)
        {
            var utilizatori = CitesteUtilizatoriDinXML();

            // verificam daca username-ul exista deja
            if (utilizatori.Any(u => u.Username == UsernameNou))
            {
                ViewBag.Eroare = "Acest utilizator exista deja!";
                return View("Index");
            }

            // adaugam in XML
            var doc = XDocument.Load(xmlPath);
            var root = doc.Element("Utilizatori");

            root.Add(new XElement("Utilizator",
                new XElement("Username", UsernameNou),
                new XElement("Parola", ParolaNoua)));

            doc.Save(xmlPath);

            ViewBag.Succes = "Cont creat cu succes!";
            return View("Index");
        }

        [HttpPost]
        public ActionResult Delete(string UsernameSters)
        {
            var doc = XDocument.Load(xmlPath);
            var root = doc.Element("Utilizatori");

            var userToRemove = root.Elements("Utilizator")
                .FirstOrDefault(u => (string)u.Element("Username") == UsernameSters);

            if (userToRemove != null)
            {
                userToRemove.Remove();
                doc.Save(xmlPath);
                ViewBag.Succes = "Cont sters cu succes!";
            }
            else
            {
                ViewBag.Eroare = "Utilizatorul nu exista!";
            }

            return View("Index");
        }

    }
}