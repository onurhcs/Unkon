using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/Profile
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.admins.Where(x => x.Username == a).FirstOrDefault();
            return View(values);
        }
    }
}