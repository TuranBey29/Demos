﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo1()
        {
            return View();
        }
        public ActionResult Demo2()
        {
            return View();
        }
        public ActionResult Demo3()
        {
            return View();
        }
    }
}