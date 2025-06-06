using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeografieKids.Models
{
    public class IntrebareSteag
    {
        public string NumeTara { get; set; }
        public string Continent { get; set; }
        public string ImagineSteag { get; set; } 
        public string CapitalaCorecta { get; set; }
        public List<string> Variante { get; set; }
    }


}