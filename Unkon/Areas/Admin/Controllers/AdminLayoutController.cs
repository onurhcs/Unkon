﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Unkon.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult PartialHead()
        {
            return PartialView();
        }
        public ActionResult PartialSidebar()
        {
            return PartialView();
        }
        public ActionResult PartialNavbar()
        {
            return PartialView();
        }
        public ActionResult PartialFooter()
        {
            return PartialView();
        }
        public ActionResult PartialScript()
        {
            return PartialView();
        }

    }
}