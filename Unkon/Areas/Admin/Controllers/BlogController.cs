using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/Blog
        public ActionResult BlogList()
        {
            var values = context.Bloglar.ToList();
            return View(values);
        }
    }
}