using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackatwitchthon.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {   

            return View("Index");
        }
        [HttpPost]
        [Route("Template")]
        public IActionResult Template()
        {
            return View("Template");
        }
    
    }
}
