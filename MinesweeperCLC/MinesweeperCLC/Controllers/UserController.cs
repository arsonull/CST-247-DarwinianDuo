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


        public IActionResult Register()
        {
            return View();
        }

        //public IActionResult ProcessRegister(string Username, string Password, string FirstName, string LastName, string Sex, int Age, string State, string Email)
        //{
        //    UserData user = new UserData(Username, Password, FirstName, LastName, Sex, Age, State, Email, 0);
        //    Console.Write(Username + ", " + Password);
        //    return View("Success", user);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult ProcessRegister(UserData user)
        {
            if (user != null)
            {
                user = userServ.register(user);
                if (user != null)
                    return View("UserDataDetails", user);
                else
                    return View("Register");
            }
            return View("Register");
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
