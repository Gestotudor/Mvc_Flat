using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlatMVC.Controllers
{
    public class HomeController : Controller
    {
        FlatContext _db = new FlatContext();
        General _settings;

        public HomeController()
        {
            _settings = _db.General.FirstOrDefault();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Menu()
        {
            return View(_settings);
        }

        public ActionResult _Header()
        {
            return View(_settings);
        }

        public ActionResult _LatestWorks()
        {
            ViewBag.Categories = _db.WorkCategories.ToList();
            return View(_db.Works.ToList());
        }

        public ActionResult _CTA1()
        {
            return View();
        }

        public ActionResult _WhatWeDo()
        {
            return View();
        }

        public ActionResult _CTA2()
        {
            return View();
        }

        public ActionResult _Contact()
        {
            return View();
        }

        public ActionResult _Footer()
        {
            return View();
        }
    }
}