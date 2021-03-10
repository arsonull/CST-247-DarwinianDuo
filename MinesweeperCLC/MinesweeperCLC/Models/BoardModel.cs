using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Models
{
    public class BoardModel
    {
        public IEnumerable<GameBoard> Board { get; set; }
    }
}
