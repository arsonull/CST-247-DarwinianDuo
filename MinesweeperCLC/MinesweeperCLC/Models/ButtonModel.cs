using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Models
{
    public class ButtonModel
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Live { get; set; }
        public int liveNeighbours { get; set; }
        public bool visited { get; set; }
        public string id { get; set; }

        public ButtonModel()
        {
            Row = -1;
            Column = -1;
            Live = false;
            liveNeighbours = 0;
            visited = false;
        }
        public ButtonModel(int r, int c)
        {
            Row = r;
            Column = c;
            Live = false;
            liveNeighbours = 0;
            visited = false;
            id = r + "," + c;
        }
    }
}
