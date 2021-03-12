﻿using System;
using System.Collections.Generic;
using System.Text;

//Author: Carson Perry

namespace BusinessLayer
{
    class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public bool Live { get; set; }

        public int liveNeighbours { get; set; }

        public bool visited { get; set; }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Live = false;
            liveNeighbours = 0;
            visited = false;
        }
        public Cell(int r, int c)
        {
            Row = r;
            Column = c;
            Live = false;
            liveNeighbours = 0;
            visited = false;
        }
    }
}
