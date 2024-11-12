using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime YayimlanmaTarihi { get; set; }
        public string Yazar { get; set; }
        public string ResimUrl { get; set; }
    }
}