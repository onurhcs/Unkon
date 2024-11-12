using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/About
        public ActionResult AboutList()
        {
            var values = context.abouts.ToList();
            return View(values);
        }
    }
}