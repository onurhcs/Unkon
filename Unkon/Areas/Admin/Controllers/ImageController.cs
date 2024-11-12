using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;
using Unkon.Entities;

namespace Unkon.Areas.Admin.Controllers
{
    public class ImageController : Controller
    {
        UnkonContext context = new UnkonContext();  
        // GET: Admin/Image
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ImageAdd(Portfoy p)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                p.ResimUrl = "~/Image/" + dosyaadi + uzanti;
            }
            context.Portfoyler.Add(p);
            context.SaveChanges();
            return View();
        }
    }
}