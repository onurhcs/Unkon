using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;
using Unkon.Entities;

namespace Unkon.Areas.Admin.Controllers
{
    public class İletişimController : Controller
    {
        UnkonContext context = new UnkonContext();  
        // GET: Admin/İletişim
        public ActionResult İletişimList()
        {
            var values =context.IletisimBilgileri.ToList();
            return View(values);
        }
    }
}