using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace JsuPlus.Controllers
{
    public class ContactController : Controller
    {
        //
        //GET: /Contact
        public IActionResult Index()
        {
            return View();
        }
        
         
        //
        //GET: /ContactEmail
        public string Welcome()
        {
            return "Please email us at support@gmail.com";
        }
    }
}
