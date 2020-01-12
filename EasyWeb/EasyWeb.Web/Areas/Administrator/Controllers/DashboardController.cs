using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyWeb.Web.Areas.Administrator.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}