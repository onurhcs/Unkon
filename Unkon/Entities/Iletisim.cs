using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class Iletisim
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string KonumUrl { get; set; } // Google Maps linki veya konum bilgisi
    }
}