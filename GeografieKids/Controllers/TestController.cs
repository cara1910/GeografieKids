using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GeografieKids.Models;

namespace GeografieKids.Controllers
{
    public class TestController : Controller
    {
        // Europa
        private static readonly List<IntrebareHarta> EuropaQuestions = new List<IntrebareHarta>
{
    new IntrebareHarta { NumeTara = "Andorra", CodSvg = "AD" },
    new IntrebareHarta { NumeTara = "Albania", CodSvg = "AL" },
    new IntrebareHarta { NumeTara = "Austria", CodSvg = "AT" },
    new IntrebareHarta { NumeTara = "Bosnia si Hertegovina", CodSvg = "BA" },
    new IntrebareHarta { NumeTara = "Belgia", CodSvg = "BE" },
    new IntrebareHarta { NumeTara = "Belarus", CodSvg = "BY" },
    new IntrebareHarta { NumeTara = "Elvetia", CodSvg = "CH" },
    new IntrebareHarta { NumeTara = "Cipru", CodSvg = "CY" },
    new IntrebareHarta { NumeTara = "Cehia", CodSvg = "CZ" },
    new IntrebareHarta { NumeTara = "Germania", CodSvg = "DE" },
    new IntrebareHarta { NumeTara = "Danemarca", CodSvg = "DK" },
    new IntrebareHarta { NumeTara = "Estonia", CodSvg = "EE" },
    new IntrebareHarta { NumeTara = "Spania", CodSvg = "ES" },
    new IntrebareHarta { NumeTara = "Finlanda", CodSvg = "FI" },
    new IntrebareHarta { NumeTara = "Franta", CodSvg = "FR" },
    new IntrebareHarta { NumeTara = "Croatia", CodSvg = "HR" },
    new IntrebareHarta { NumeTara = "Ungaria", CodSvg = "HU" },
    new IntrebareHarta { NumeTara = "Irlanda", CodSvg = "IE" },
    new IntrebareHarta { NumeTara = "Islanda", CodSvg = "IS" },
    new IntrebareHarta { NumeTara = "Italia", CodSvg = "IT" },
    new IntrebareHarta { NumeTara = "Liechtenstein", CodSvg = "LI" },
    new IntrebareHarta { NumeTara = "Lituania", CodSvg = "LT" },
    new IntrebareHarta { NumeTara = "Luxenburg", CodSvg = "LU" },
    new IntrebareHarta { NumeTara = "Latvia", CodSvg = "LV" },
    new IntrebareHarta { NumeTara = "Republica Moldova", CodSvg = "MD" },
    new IntrebareHarta { NumeTara = "Muntenegru", CodSvg = "ME" },
    new IntrebareHarta { NumeTara = "Macedonia de Nord", CodSvg = "MK" },
    new IntrebareHarta { NumeTara = "Tarile de Jos", CodSvg = "NL" },
    new IntrebareHarta { NumeTara = "Norvegia", CodSvg = "NO" },
    new IntrebareHarta { NumeTara = "Polonia", CodSvg = "PL" },
    new IntrebareHarta { NumeTara = "Portugalia", CodSvg = "PT" },
    new IntrebareHarta { NumeTara = "Romania", CodSvg = "RO" },
    new IntrebareHarta { NumeTara = "Serbia", CodSvg = "RS" },
    new IntrebareHarta { NumeTara = "Suedia", CodSvg = "SE" },
    new IntrebareHarta { NumeTara = "Slovenia", CodSvg = "SI" },
    new IntrebareHarta { NumeTara = "Slovacia", CodSvg = "SK" },
    new IntrebareHarta { NumeTara = "Turcia", CodSvg = "TR" },
    new IntrebareHarta { NumeTara = "Ucraina", CodSvg = "UA" },
    new IntrebareHarta { NumeTara = "Kosovo", CodSvg = "XK" },
};

        // Asia
        private static readonly List<IntrebareHarta> AsiaQuestions = new List<IntrebareHarta>
{
    new IntrebareHarta { NumeTara = "Afghanistan", CodSvg = "Afghanistan" },
    new IntrebareHarta { NumeTara = "Armenia", CodSvg = "Armenia" },
    new IntrebareHarta { NumeTara = "Azerbaijan", CodSvg = "Azerbaijan" },
    new IntrebareHarta { NumeTara = "Bahrain", CodSvg = "Bahrain" },
    new IntrebareHarta { NumeTara = "Bangladesh", CodSvg = "Bangladesh" },
    new IntrebareHarta { NumeTara = "Bhutan", CodSvg = "Bhutan" },
    new IntrebareHarta { NumeTara = "Brunei", CodSvg = "Brunei" },
    new IntrebareHarta { NumeTara = "Cambodia", CodSvg = "Cambodia" },
    new IntrebareHarta { NumeTara = "China", CodSvg = "China" },
    new IntrebareHarta { NumeTara = "Hong_Kong", CodSvg = "Hong_Kong" },
    new IntrebareHarta { NumeTara = "India", CodSvg = "India" },
    new IntrebareHarta { NumeTara = "Indonesia", CodSvg = "Indonesia" },
    new IntrebareHarta { NumeTara = "Iran", CodSvg = "Iran" },
    new IntrebareHarta { NumeTara = "Iraq", CodSvg = "Iraq" },
    new IntrebareHarta { NumeTara = "Israel", CodSvg = "Israel" },
    new IntrebareHarta { NumeTara = "Japan", CodSvg = "Japan" },
    new IntrebareHarta { NumeTara = "Jordan", CodSvg = "Jordan" },
    new IntrebareHarta { NumeTara = "Kazakhstan", CodSvg = "Kazakhstan" },
    new IntrebareHarta { NumeTara = "Kuwait", CodSvg = "Kuwait" },
    new IntrebareHarta { NumeTara = "Kyrgyzstan", CodSvg = "Kyrgyzstan" },
    new IntrebareHarta { NumeTara = "Laos", CodSvg = "Laos" },
    new IntrebareHarta { NumeTara = "Lebanon", CodSvg = "Lebanon" },
    new IntrebareHarta { NumeTara = "Malaysia", CodSvg = "Malaysia" },
    new IntrebareHarta { NumeTara = "Maldives", CodSvg = "Maldives" },
    new IntrebareHarta { NumeTara = "Mongolia", CodSvg = "Mongolia" },
    new IntrebareHarta { NumeTara = "Myanmar", CodSvg = "Myanmar" },
    new IntrebareHarta { NumeTara = "Nepal", CodSvg = "Nepal" },
    new IntrebareHarta { NumeTara = "North_Korea", CodSvg = "North_Korea" },
    new IntrebareHarta { NumeTara = "Oman", CodSvg = "Oman" },
    new IntrebareHarta { NumeTara = "Pakistan", CodSvg = "Pakistan" },
    new IntrebareHarta { NumeTara = "Palestinian_Territories", CodSvg = "Palestinian_Territories" },
    new IntrebareHarta { NumeTara = "Philippines", CodSvg = "Philippines" },
    new IntrebareHarta { NumeTara = "Qatar", CodSvg = "Qatar" },
    new IntrebareHarta { NumeTara = "Russia", CodSvg = "Russia" },
    new IntrebareHarta { NumeTara = "Saudi_Arabia", CodSvg = "Saudi_Arabia" },
    new IntrebareHarta { NumeTara = "Singapore", CodSvg = "Singapore" },
    new IntrebareHarta { NumeTara = "South_Korea", CodSvg = "South_Korea" },
    new IntrebareHarta { NumeTara = "Sri_Lanka", CodSvg = "Sri_Lanka" },
    new IntrebareHarta { NumeTara = "Syria", CodSvg = "Syria" },
    new IntrebareHarta { NumeTara = "Taiwan", CodSvg = "Taiwan" },
    new IntrebareHarta { NumeTara = "Tajikistan", CodSvg = "Tajikistan" },
    new IntrebareHarta { NumeTara = "Thailand", CodSvg = "Thailand" },
    new IntrebareHarta { NumeTara = "Timor_Leste", CodSvg = "Timor_Leste" },
    new IntrebareHarta { NumeTara = "Turkmenistan", CodSvg = "Turkmenistan" },
    new IntrebareHarta { NumeTara = "Türkiye", CodSvg = "Türkiye" },
    new IntrebareHarta { NumeTara = "United_Arab_Emirates", CodSvg = "United_Arab_Emirates" },
    new IntrebareHarta { NumeTara = "Uzbekistan", CodSvg = "Uzbekistan" },
    new IntrebareHarta { NumeTara = "Vietnam", CodSvg = "Vietnam" },
    new IntrebareHarta { NumeTara = "Yemen", CodSvg = "Yemen" }
};

        // Africa
        private static readonly List<IntrebareHarta> AfricaQuestions = new List<IntrebareHarta>
{
    new IntrebareHarta { NumeTara = "Angola", CodSvg = "AO" },
    new IntrebareHarta { NumeTara = "Burkina Faso", CodSvg = "BF" },
    new IntrebareHarta { NumeTara = "Burundi", CodSvg = "BI" },
    new IntrebareHarta { NumeTara = "Benin", CodSvg = "BJ" },
    new IntrebareHarta { NumeTara = "Botswana", CodSvg = "BW" },
    new IntrebareHarta { NumeTara = "Republica Democrată Congo", CodSvg = "CD" },
    new IntrebareHarta { NumeTara = "Republica Centrafricană", CodSvg = "CF" },
    new IntrebareHarta { NumeTara = "Congo", CodSvg = "CG" },
    new IntrebareHarta { NumeTara = "Coasta de Fildeș", CodSvg = "CI" },
    new IntrebareHarta { NumeTara = "Camerun", CodSvg = "CM" },
    new IntrebareHarta { NumeTara = "Djibouti", CodSvg = "DJ" },
    new IntrebareHarta { NumeTara = "Algeria", CodSvg = "DZ" },
    new IntrebareHarta { NumeTara = "Egipt", CodSvg = "EG" },
    new IntrebareHarta { NumeTara = "Sahara Occidentală", CodSvg = "EH" },
    new IntrebareHarta { NumeTara = "Eritreea", CodSvg = "ER" },
    new IntrebareHarta { NumeTara = "Etiopia", CodSvg = "ET" },
    new IntrebareHarta { NumeTara = "Gabon", CodSvg = "GA" },
    new IntrebareHarta { NumeTara = "Ghana", CodSvg = "GH" },
    new IntrebareHarta { NumeTara = "Gambia", CodSvg = "GM" },
    new IntrebareHarta { NumeTara = "Guineea", CodSvg = "GN" },
    new IntrebareHarta { NumeTara = "Guineea Ecuatorială", CodSvg = "GQ" },
    new IntrebareHarta { NumeTara = "Guineea-Bissau", CodSvg = "GW" },
    new IntrebareHarta { NumeTara = "Kenya", CodSvg = "KE" },
    new IntrebareHarta { NumeTara = "Comore", CodSvg = "KM" },
    new IntrebareHarta { NumeTara = "Liberia", CodSvg = "LR" },
    new IntrebareHarta { NumeTara = "Lesotho", CodSvg = "LS" },
    new IntrebareHarta { NumeTara = "Libia", CodSvg = "LY" },
    new IntrebareHarta { NumeTara = "Maroc", CodSvg = "MA" },
    new IntrebareHarta { NumeTara = "Madagascar", CodSvg = "MG" },
    new IntrebareHarta { NumeTara = "Mali", CodSvg = "ML" },
    new IntrebareHarta { NumeTara = "Mauritania", CodSvg = "MR" },
    new IntrebareHarta { NumeTara = "Malawi", CodSvg = "MW" },
    new IntrebareHarta { NumeTara = "Mozambic", CodSvg = "MZ" },
    new IntrebareHarta { NumeTara = "Namibia", CodSvg = "NA" },
    new IntrebareHarta { NumeTara = "Niger", CodSvg = "NE" },
    new IntrebareHarta { NumeTara = "Nigeria", CodSvg = "NG" },
    new IntrebareHarta { NumeTara = "Réunion", CodSvg = "RE" },
    new IntrebareHarta { NumeTara = "Rwanda", CodSvg = "RW" },
    new IntrebareHarta { NumeTara = "Seychelles", CodSvg = "SC" },
    new IntrebareHarta { NumeTara = "Sudan", CodSvg = "SD" },
    new IntrebareHarta { NumeTara = "Sfânta Elena", CodSvg = "SH" },
    new IntrebareHarta { NumeTara = "Sierra Leone", CodSvg = "SL" },
    new IntrebareHarta { NumeTara = "Senegal", CodSvg = "SN" },
    new IntrebareHarta { NumeTara = "Somalia", CodSvg = "SO" },
    new IntrebareHarta { NumeTara = "Sudanul de Sud", CodSvg = "SS" },
    new IntrebareHarta { NumeTara = "São Tomé și Príncipe", CodSvg = "ST" },
    new IntrebareHarta { NumeTara = "Eswatini", CodSvg = "SZ" },
    new IntrebareHarta { NumeTara = "Ciad", CodSvg = "TD" },
    new IntrebareHarta { NumeTara = "Togo", CodSvg = "TG" },
    new IntrebareHarta { NumeTara = "Tunisia", CodSvg = "TN" },
    new IntrebareHarta { NumeTara = "Tanzania", CodSvg = "TZ" },
    new IntrebareHarta { NumeTara = "Uganda", CodSvg = "UG" },
    new IntrebareHarta { NumeTara = "Africa de Sud", CodSvg = "ZA" },
    new IntrebareHarta { NumeTara = "Zambia", CodSvg = "ZM" },
    new IntrebareHarta { NumeTara = "Zimbabwe", CodSvg = "ZW" },
};
        //America
        private static readonly List<IntrebareHarta> AmericaQuestions = new List<IntrebareHarta>
{
    new IntrebareHarta { NumeTara = "Argentina", CodSvg = "ar" },
    new IntrebareHarta { NumeTara = "Barbados", CodSvg = "bb" },
    new IntrebareHarta { NumeTara = "Bermude", CodSvg = "bm" },
    new IntrebareHarta { NumeTara = "Bolivia", CodSvg = "bo" },
    new IntrebareHarta { NumeTara = "Brazilia", CodSvg = "br" },
    new IntrebareHarta { NumeTara = "Bahamas", CodSvg = "bs" },
    new IntrebareHarta { NumeTara = "Belize", CodSvg = "bz" },
    new IntrebareHarta { NumeTara = "Canada", CodSvg = "ca" },
    new IntrebareHarta { NumeTara = "Chile", CodSvg = "cl" },
    new IntrebareHarta { NumeTara = "Columbia", CodSvg = "co" },
    new IntrebareHarta { NumeTara = "Costa Rica", CodSvg = "cr" },
    new IntrebareHarta { NumeTara = "Cuba", CodSvg = "cu" },
    new IntrebareHarta { NumeTara = "Republica Dominicană", CodSvg = "do" },
    new IntrebareHarta { NumeTara = "Ecuador", CodSvg = "ec" },
    new IntrebareHarta { NumeTara = "Grenada", CodSvg = "gd" },
    new IntrebareHarta { NumeTara = "Guiana Franceză", CodSvg = "gf" },
    new IntrebareHarta { NumeTara = "Guatemala", CodSvg = "gt" },
    new IntrebareHarta { NumeTara = "Guyana", CodSvg = "gy" },
    new IntrebareHarta { NumeTara = "Honduras", CodSvg = "hn" },
    new IntrebareHarta { NumeTara = "Haiti", CodSvg = "ht" },
    new IntrebareHarta { NumeTara = "Jamaica", CodSvg = "jm" },
    new IntrebareHarta { NumeTara = "Insulele Cayman", CodSvg = "ky" },
    new IntrebareHarta { NumeTara = "Mexic", CodSvg = "mx" },
    new IntrebareHarta { NumeTara = "Nicaragua", CodSvg = "ni" },
    new IntrebareHarta { NumeTara = "Panama", CodSvg = "pa" },
    new IntrebareHarta { NumeTara = "Peru", CodSvg = "pe" },
    new IntrebareHarta { NumeTara = "Pitcairn", CodSvg = "pn" },
    new IntrebareHarta { NumeTara = "Puerto Rico", CodSvg = "pr" },
    new IntrebareHarta { NumeTara = "Paraguay", CodSvg = "py" },
    new IntrebareHarta { NumeTara = "Surinam", CodSvg = "sr" },
    new IntrebareHarta { NumeTara = "El Salvador", CodSvg = "sv" },
    new IntrebareHarta { NumeTara = "Statele Unite ale Americii", CodSvg = "us" },
    new IntrebareHarta { NumeTara = "Uruguay", CodSvg = "uy" },
    new IntrebareHarta { NumeTara = "Venezuela", CodSvg = "ve" },
};

        // START TEST 
        public ActionResult StartTest()
        {
            // se preiau tipul testului si continentul selectat
            string tipTest = Session["TipTest"] as string;
            string continent = Session["Continent"] as string;

            // verifica daca valorile sunt valide
            if (string.IsNullOrEmpty(tipTest) || string.IsNullOrEmpty(continent))
            {
                return RedirectToAction("Index", "SelectareTest");
            }

            // redirectionare catre testul potrivit
            if (tipTest == "Harta")
            {
                return RedirectToAction("TestHarta", new { continent });
            }

            if (tipTest == "Steaguri")
            {
                return RedirectToAction("TestSteaguri", new { continent });
            }

            return RedirectToAction("Index", "SelectareTest");
        }

        // TEST HARTA
        public ActionResult TestHarta(string continent)
        {
            // se initializeaza lista de intrebari pe baza continentului
            List<IntrebareHarta> intrebari = new List<IntrebareHarta>();

            if (continent == "Europa")
                intrebari = EuropaQuestions;
            else if (continent == "Asia")
                intrebari = AsiaQuestions;
            else if (continent == "Africa")
                intrebari = AfricaQuestions;
            else if (continent == "America")
                intrebari = AmericaQuestions;
            else
                return RedirectToAction("Index", "SelectareContinent");

            // se aleg 10 intrebari random
            var intrebariRandom = intrebari.OrderBy(x => Guid.NewGuid()).Take(10).ToList();

            // Se salveaza in sesiune
            Session["IntrebariHarta"] = intrebariRandom;
            Session["IndexCurent"] = 0;
            Session["Scor"] = 0;
            Session["Continent"] = continent;

            return RedirectToAction("AfiseazaIntrebare");
        }

        public ActionResult AfiseazaIntrebare()
        {
            // se obține lista de intrebari si indexul curent
            var intrebari = Session["IntrebariHarta"] as List<IntrebareHarta>;
            int indexCurent = (int)Session["IndexCurent"];
            string continent = Session["Continent"] as string;

            // daca am terminat intrebarile mergem la final
            if (indexCurent >= intrebari.Count)
            {
                return RedirectToAction("Final");
            }

            // se trimite intrebarea curenta catre view-ul corespunzator
            var intrebare = intrebari[indexCurent];
            return View($"~/Views/Test/TestHarta{continent}.cshtml", intrebare);
        }

        [HttpPost]

        public ActionResult VerificaRaspuns(string codSvgSelectat)
        {
            var intrebari = Session["IntrebariHarta"] as List<IntrebareHarta>;
            int index = (int)Session["IndexCurent"];

            // verificare de siguranta
            if (index >= intrebari.Count)
            {
                return Json(new { finalizat = true });
            }

            var intrebareCurenta = intrebari[index];
            bool esteCorect = codSvgSelectat == intrebareCurenta.CodSvg;

            if (esteCorect)
            {
                int scor = (int)(Session["Scor"] ?? 0);
                scor++;
                Session["Scor"] = scor;
            }

            Session["IndexCurent"] = index + 1;

            return Json(new { corect = esteCorect, finalizat = index + 1 >= intrebari.Count });
        }


        // TEST STEAGURI
        public ActionResult TestSteaguri(string continent)
        {
            List<IntrebareSteag> intrebari = new List<IntrebareSteag>();

            if (continent == "Europa")
                intrebari = SteaguriEuropa;
            else if (continent == "Asia")
                intrebari = SteaguriAsia;
            else if (continent == "Africa")
                intrebari = SteaguriAfrica;
            else if (continent == "America")
                intrebari = SteaguriAmerica;
            else
                return RedirectToAction("Index", "SelectareContinent");

            var intrebariRandom = intrebari.OrderBy(x => Guid.NewGuid()).Take(5).ToList();

            Session["IntrebariSteag"] = intrebariRandom;
            Session["IndexCurent"] = 0;
            Session["Scor"] = 0;
            Session["Continent"] = continent;

            return RedirectToAction("AfiseazaIntrebareSteag");
        }

        public ActionResult AfiseazaIntrebareSteag()
        {
            var intrebari = Session["IntrebariSteag"] as List<IntrebareSteag>;
            int indexCurent = (int)Session["IndexCurent"];

            if (indexCurent >= intrebari.Count)
            {
                return RedirectToAction("Final");
            }

            var intrebare = intrebari[indexCurent];
            intrebare.Continent = Session["Continent"] as string;

            return View("TestSteaguri", intrebare);
        }

        [HttpPost]
        public ActionResult VerificaRaspunsSteag(string raspuns)
        {
            var intrebari = Session["IntrebariSteag"] as List<IntrebareSteag>;
            int index = (int)Session["IndexCurent"];
            int scor = (int)Session["Scor"];

            if (index >= intrebari.Count)
            {
                return Json(new { finalizat = true });
            }

            var intrebareCurenta = intrebari[index];
            bool esteCorect = raspuns == intrebareCurenta.CapitalaCorecta;

            if (esteCorect)
            {
                scor++;
            }

            Session["Scor"] = scor;
            Session["IndexCurent"] = index + 1;

            return Json(new { corect = esteCorect, finalizat = index + 1 >= intrebari.Count });
        }

        // FINAL
        public ActionResult Final()
        {
            int scor = (int)(Session["Scor"] ?? 0);
            int total = 0;

            if (Session["IntrebariHarta"] != null)
                total = ((List<IntrebareHarta>)Session["IntrebariHarta"]).Count;
            else if (Session["IntrebariSteag"] != null)
                total = ((List<IntrebareSteag>)Session["IntrebariSteag"]).Count;

            ViewBag.Scor = scor;
            ViewBag.Total = total;

            return View();
        }

        // steaguri europa
        private static readonly List<IntrebareSteag> SteaguriEuropa = new List<IntrebareSteag>
        {
            new IntrebareSteag {
                NumeTara = "Albania",
                ImagineSteag = "albania.png",
                CapitalaCorecta = "Tirana",
                Variante = new List<string> { "Sofia", "Praga", "Tirana" }
            },
            new IntrebareSteag {
                NumeTara = "Austria",
                ImagineSteag = "austria.png",
                CapitalaCorecta = "Viena",
                Variante = new List<string> { "Viena", "Bratislava", "Zagreb" }
            },
            new IntrebareSteag {
                NumeTara = "Germania",
                ImagineSteag = "germania.png",
                CapitalaCorecta = "Berlin",
                Variante = new List<string> { "Amsterdam", "Berlin", "Varșovia" }
            },
            new IntrebareSteag {
                NumeTara = "România",
                ImagineSteag = "romania.png",
                CapitalaCorecta = "București",
                Variante = new List<string> { "Chișinău", "Belgrad", "București" }
            },
            new IntrebareSteag {
                NumeTara = "Spania",
                ImagineSteag = "spania.png",
                CapitalaCorecta = "Madrid",
                Variante = new List<string> { "Lisabona", "Madrid", "Roma" }
            }
        };

        //steaguri asia
        private static readonly List<IntrebareSteag> SteaguriAsia = new List<IntrebareSteag>
        {
            new IntrebareSteag {
                NumeTara = "Afganistan",
                ImagineSteag = "afganistan.png",
                CapitalaCorecta = "Kabul",
                Variante = new List<string> { "Kabul", "Islamabad", "Teheran" }
        },
            new IntrebareSteag {
                NumeTara = "China",
                ImagineSteag = "china.png",
                CapitalaCorecta = "Beijing",
                Variante = new List<string> { "Seul", "Beijing", "Tokyo" }
        },
            new IntrebareSteag {
                NumeTara = "India",
                ImagineSteag = "india.png",
                CapitalaCorecta = "New Delhi",
                Variante = new List<string> {"Mumbai", "New Delhi", "Dhaka" }
        },
            new IntrebareSteag {
                NumeTara = "Pakistan",
                ImagineSteag = "pakistan.png",
                CapitalaCorecta = "Islamabad",
                Variante = new List<string> { "Islamabad", "Kabul", "Bagdad" }
        },
            new IntrebareSteag {
                NumeTara = "Rusia",
                ImagineSteag = "rusia.jpeg",
                CapitalaCorecta = "Moscova",
                Variante = new List<string> { "Minsk", "București", "Moscova" }
            },
        };

        //steaguri africa
        private static readonly List<IntrebareSteag> SteaguriAfrica = new List<IntrebareSteag>
        {
            new IntrebareSteag {
                NumeTara = "Africa de Sud",
                ImagineSteag = "africades.png",
                CapitalaCorecta = "Pretoria",
                Variante = new List<string> { "Nairobi", "Luanda", "Pretoria" }
            },
            new IntrebareSteag {
                NumeTara = "Camerun",
                ImagineSteag = "camerun.png",
                CapitalaCorecta = "Yaoundé",
                Variante = new List<string> { "Yaoundé", "Libreville", "Accra" }
            },
            new IntrebareSteag {
                NumeTara = "Ciad",
                ImagineSteag = "ciad.png",
                CapitalaCorecta = "N'Djamena",
                Variante = new List<string> { "Bamako", "N'Djamena", "Kampala" }
            },
            new IntrebareSteag {
                NumeTara = "Egipt",
                ImagineSteag = "egipt.png",
                CapitalaCorecta = "Cairo",
                Variante = new List<string> { "Cairo", "Khartoum", "Rabat" }
            },
            new IntrebareSteag {
                NumeTara = "Etiopia",
                ImagineSteag = "etiopia.png",
                CapitalaCorecta = "Addis Abeba",
                Variante = new List<string> { "Addis Abeba", "Asmara", "Lusaka" }
            },
        };

        //steaguri america
        private static readonly List<IntrebareSteag> SteaguriAmerica = new List<IntrebareSteag>
        {
            new IntrebareSteag {
                NumeTara = "Argentina",
                ImagineSteag = "argentina.png",
                CapitalaCorecta = "Buenos Aires",
                Variante = new List<string> { "Buenos Aires", "Santiago", "Lima" }
            },
            new IntrebareSteag {
                NumeTara = "Canada",
                ImagineSteag = "canada.png",
                CapitalaCorecta = "Ottawa",
                Variante = new List<string> { "Ottawa", "Toronto", "Montreal" }
            },
            new IntrebareSteag {
                NumeTara = "Columbia",
                ImagineSteag = "columbia.png",
                CapitalaCorecta = "Bogotá",
                Variante = new List<string> { "Bogotá", "Quito", "Caracas" }
            },
            new IntrebareSteag {
                NumeTara = "Cuba",
                ImagineSteag = "cuba.png",
                CapitalaCorecta = "Havana",
                Variante = new List<string> { "Havana", "San Juan", "Santo Domingo" }
            },
            new IntrebareSteag {
                NumeTara = "Jamaica",
                ImagineSteag = "jamaica.png",
                CapitalaCorecta = "Kingston",
                Variante = new List<string> { "Kingston", "Nassau", "Port-au-Prince" }
            },
        };

    }
}
