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
        private static GameBoard webBoard;

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CreateBoard(int Size)
        {
            GameBoard board = new GameBoard(Size);
            board.createBombs(4);
            board.checkNeighbors2();
            webBoard = board;
            return View("Game", board);
        }

        public IActionResult Click(String buttonNumber)
        {
            Char[] buttArr = buttonNumber.ToCharArray();
            int row = int.Parse(buttArr[0].ToString());
            int col = int.Parse(buttArr[2].ToString());
            webBoard.floodFill(row, col);
            if (webBoard.checkWin())
                return PartialView("Win", webBoard);
            else if (webBoard.grid[row, col].Live)
                return PartialView("Lose", webBoard);
            else
                return PartialView("PartialGame", webBoard);
        }
    }
}
