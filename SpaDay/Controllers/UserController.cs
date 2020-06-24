using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaDay.Models;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if( newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            
            return View();
        }
    }
}
