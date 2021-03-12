using Microsoft.AspNetCore.Mvc;
using MinesweeperCLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Controllers
{
    public class MinesweeperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateBoard()
        {
            int size;
        }
    }
}
