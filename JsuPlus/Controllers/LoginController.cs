using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsuPlus.Controllers
{
    public class LoginController : Controller
    {
        //
        //GET: /Login
        public IActionResult Index()
        {
            return View();
        }
    }
}
