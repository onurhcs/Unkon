using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unkon.Context;

namespace Unkon.Controllers
{
    public class DefaultController : Controller
    {
        UnkonContext context = new UnkonContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead() //Başlık
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar() //Navbar
        {
            return PartialView();
        }
        public PartialViewResult PartialHero() //Sİte Başlığı
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout() //Hakkımızda
        {
            var values = context.abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeatures()
        {
            var values = context.HakkimizdaBilgileri.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCall()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = context.Hizmetler.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialPortfolio()
        {
            return PartialView();
        }
        public PartialViewResult PartialFaq()
        {
            var values = context.SSSler.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = context.IletisimBilgileri.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();

        }
    }
}