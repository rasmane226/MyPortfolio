﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
