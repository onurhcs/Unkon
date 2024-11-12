using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Paragraf1 { get; set; } // İlk paragraf içeriği
        public string Paragraf2 { get; set; } // İkinci paragraf içeriği

        public string Madde1 { get; set; }    // İlk madde içeriği
        public string Madde2 { get; set; }    // İkinci madde içeriği
        public string Madde3 { get; set; }    // Üçüncü madde içeriği

        public string ButonMetni { get; set; } // Buton üzerinde görünen metin, örneğin "Daha Fazla Bilgi"
    }
}