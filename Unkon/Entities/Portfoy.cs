using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class Portfoy
    {
        public int Id { get; set; }
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public string ResimUrl { get; set; } // Projeye ait bir görselin URL'si
    }
}