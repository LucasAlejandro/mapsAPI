﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mapsAPI.Controllers
{
    public class GeoController : Controller
    {
        // GET: Geo
        public ActionResult InfoWindow()
        {
            return View();
        }
        public ActionResult Autocomplete()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GeoCoder()
        {
            return View();
        }
        public ActionResult MarkerCluster()
        {
            return View();
        }

    }
}