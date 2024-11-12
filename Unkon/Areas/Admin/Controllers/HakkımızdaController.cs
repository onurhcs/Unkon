using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    public class HakkımızdaController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/Hakkımızda
        public ActionResult HakkımızdaList()
        {
            var values = context.HakkimizdaBilgileri.ToList();
            return View(values);
        }
    }
}