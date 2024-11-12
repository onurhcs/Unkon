using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unkon.Entities;

namespace Unkon.Context
{
    public class UnkonContext : DbContext
    {

        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Hakkimizda> HakkimizdaBilgileri { get; set; }
        public DbSet<Iletisim> IletisimBilgileri { get; set; }
        public DbSet<Portfoy> Portfoyler { get; set; }
        public DbSet<SSS> SSSler { get; set; }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}