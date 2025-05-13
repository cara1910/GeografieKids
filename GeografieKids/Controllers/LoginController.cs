using GeografieKids.Models;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace GeografieKids.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autentificare(string username, string parola)
        {
            List<Utilizator> utilizatori = CitesteUtilizatori();

            foreach (var u in utilizatori)
            {
                if (u.Username == username && u.Parola == parola)
                {
                    Session["utilizator"] = u.Username;
                    return RedirectToAction("Selectare", "Quiz");
                }
            }

            ViewBag.Eroare = "Username sau parola incorecte.";
            return View("Index");
        }

        private List<Utilizator> CitesteUtilizatori()
        {
            string path = Server.MapPath("~/App_Data/utilizatori.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Utilizator>), new XmlRootAttribute("Utilizatori"));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (List<Utilizator>)serializer.Deserialize(fs);
            }
        }
    }
}
