using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unkon.Entities
{
    public class Hizmet
    {
        public int Id { get; set; }
        public string Baslik { get; set; } // Hizmet başlığı (ör. "Bakım ve Onarım")
        public string Aciklama { get; set; } // Hizmet açıklaması
        public string IconPath { get; set; } // Hizmet ikonunun dosya yolu
    }
}