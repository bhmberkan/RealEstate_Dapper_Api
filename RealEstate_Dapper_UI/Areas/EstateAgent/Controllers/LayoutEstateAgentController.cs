﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")] // controllerın hangi areaya ait olduğunu belirtmek zorunlu.
    public class LayoutEstateAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
