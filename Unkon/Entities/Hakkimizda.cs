using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class Hakkimizda
    {
        public int Id { get; set; }
        public string Baslik { get; set; } // Başlık (ör. "Bizi Tanıyın")
        public string Icerik { get; set; } // Hakkımızda detaylı içerik
        public string AltBaslik { get; set; } // Ekstra başlık, varsa
        public string AltBaslik1 { get; set; } // Ekstra başlık, varsa
        public string AltBaslik2 { get; set; } // Ekstra başlık, varsa
    }
}