using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Unkon.Context;
using Unkon.Entities;

namespace Unkon.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UnkonContext context = new UnkonContext();  
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["x"]=values.Username;
                return RedirectToAction("Index","Profile", new { area = "Admin" });
            } 
            else
            {
                 return View();
            }

        }
    }
}