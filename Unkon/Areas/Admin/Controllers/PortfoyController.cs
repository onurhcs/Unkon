using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;
using Unkon.Entities;
namespace Unkon.Areas.Admin.Controllers
{
    public class PortfoyController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Admin/Portfoy
        [Authorize]
        public ActionResult PortfoyList()
        {
            var values = context.Portfoyler.ToList();
            return View(values);
        }
        public ActionResult CreatePortfoy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePortfoy(Portfoy portfoy)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    context.Portfoyler.Add(portfoy);
                    context.SaveChanges();
                    return RedirectToAction("ProjectsList", "Portfoyler", "Admin");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayabilir veya görüntüleyebilirsiniz
                ModelState.AddModelError("", "Bir hata oluştu: " + ex.Message);
            }
            return View(portfoy);
        }

        public ActionResult DeletePortfoy(int id)
        {
            var value = context.Portfoyler.Find(id);
            context.Portfoyler.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectsList", "Projects", "Admin");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = context.Portfoyler.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(Portfoy portfoy)
        {
            var value = context.Portfoyler.Find(portfoy.Id);
            value.ProjeAdi = portfoy.ProjeAdi;
            value.Aciklama = portfoy.Aciklama;
            value.ResimUrl = portfoy.ResimUrl;

            context.SaveChanges();
            return RedirectToAction("ProjectsList", "Projects", "Admin");

        }
    }
}