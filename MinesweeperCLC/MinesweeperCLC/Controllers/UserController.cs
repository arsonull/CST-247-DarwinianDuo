using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinesweeperCLC.Models;
using MinesweeperCLC.Services.Business;

namespace EmployeeCrud.Controllers
{
    public class UserController : Controller
    {
        UserBusinessService userServ = new UserBusinessService();
        public IActionResult Index()
        {
            List<UserData> usrList = new List<UserData>();

            usrList = userServ.getAllUsers();
            return View(usrList);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind] UserData usr)
        {
            if (ModelState.IsValid)
            {
                userServ.register(usr);
                return RedirectToAction("Index");
            }
            return View(usr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind] UserData usr)
        {
            if (ModelState.IsValid)
            {
                userServ.login(usr);
                return RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine("User not defined");
                return View(usr);
            }
        }
    }
}
