﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AJAXDemo.Models;

namespace AJAXDemo.Controllers
{
    public class HomeController : Controller
    {
        private AJAXDemoContext db = new AJAXDemoContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }
        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }
        public IActionResult DisplayViewWithAjax()
        {
            return View();
        }
        public IActionResult RandomDestinationList(int destinationCount)
        {
            var randomDestinationList = db.Destinations.OrderBy(r => Guid.NewGuid()).Take(destinationCount);
            return Json(randomDestinationList);
        }
    }
}
