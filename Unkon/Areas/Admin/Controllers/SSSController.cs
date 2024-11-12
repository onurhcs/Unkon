using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    public class SSSController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/SSS
        public ActionResult SoruList()
        {
            var values = context.SSSler.ToList();
            return View(values);
        }
    }
}