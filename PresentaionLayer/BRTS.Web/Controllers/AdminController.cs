﻿using Microsoft.AspNetCore.Mvc;

namespace BRTS.Web.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult AdminDashBoard()
        {
            return View();
        }


    }
}
