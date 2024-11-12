using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    public class HizmetController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/Hizmet
        public ActionResult HizmetList()
        {
            var values = context.Hizmetler.ToList();
            return View(values);
        }
    }
}