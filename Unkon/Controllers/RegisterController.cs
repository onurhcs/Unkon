using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;
using Unkon.Entities;

namespace Unkon.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        UnkonContext context = new UnkonContext();  
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index", "Login");

        }
    }
}