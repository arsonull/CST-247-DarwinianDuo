using System;
using System.Collections.Generic;
using System.Text;

//Author: Carson Perry

namespace MinesweeperCLC.Models
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Live { get; set; }
        public int liveNeighbours { get; set; }
        public bool visited { get; set; }
        public string id { get; set; }
        public bool flagged { get; set; }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Live = false;
            liveNeighbours = 0;
            visited = false;
            flagged = false;
        }
        public Cell(int r, int c)
        {
            Row = r;
            Column = c;
            Live = false;
            liveNeighbours = 0;
            visited = false;
            id = r + "," + c;
            flagged = false;
        }
    }
}
