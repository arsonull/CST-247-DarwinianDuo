using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

//Author: Carson Perry

namespace MinesweeperCLC.Models
{
    public class GameBoard
    {
        [BindProperty]
        public int Size { get; set; }
        [BindProperty]
        public int Difficulty { get; set; }
        [BindProperty]
        public int NumBombs { get; set; }
        [BindProperty]
        public Cell[,] grid { get; }

        public GameBoard(int s)
        {
            Size = s;
            NumBombs = 0;

            //creating the grid of cells
            grid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
        }

        //Set cells as Live randomely based on Difficulty
        public void createBombs(int d)
        {
            Random rand = new Random();

            int bombs = d * Size;

            for (int b = 0; b < bombs; b++)
            {
                int x = rand.Next(Size);
                int y = rand.Next(Size);
                if (!grid[x, y].Live)
                {
                    grid[x, y].Live = true;
                    NumBombs += 1;
                }
                else
                {
                    b--;
                }
            }
        }
       
        //Sets each cell to check how many bombs are near them within one block cardinally, or diagonally
        public void checkNeighbors2()
        {
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    int n = 0;
                    if (r < Size - 1)
                    {
                        if (grid[r + 1, c].Live) { n++; }
                    }
                    if (r < Size - 1 && c < Size - 1) { if (grid[r + 1, c + 1].Live) { n++; } }
                    if (c > 0 && r < Size - 1)
                    {
                        if (grid[r + 1, c - 1].Live) { n++; }
                    }
                    if (r > 0 && c < Size - 1)
                    {
                        if (grid[r - 1, c + 1].Live) { n++; }
                    }
                    if (r > 0)
                    {
                        if (grid[r - 1, c].Live) { n++; }
                    }
                    if (c > 0)
                    {
                        if (grid[r, c - 1].Live) { n++; }
                    }
                    if (r > 0 && c > 0) { if (grid[r - 1, c - 1].Live) { n++; } }
                    if (c < Size - 1) { if (grid[r, c + 1].Live) { n++; } }
                    if (n == 8 && grid[r, c].Live) { n++; }
                    grid[r, c].liveNeighbours = n;
                }
            }
        }
        //Recursive method to "visit" all linking 0 live neighbor cells along with their surroundings
        public void floodFill(int r, int c)
        {
            if (r < 0 || c < 0) { return; }
            if (r >= Size || c >= Size) { return; }
            if (!grid[r, c].Live && grid[r, c].liveNeighbours == 0 && !grid[r, c].visited)
            {
                grid[r, c].visited = true;
                floodFill(r + 1, c);
                floodFill(r - 1, c);
                floodFill(r, c + 1);
                floodFill(r, c - 1);
                return;
            }
            else if (!grid[r, c].Live && !grid[r, c].visited)
            {
                grid[r, c].visited = true;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
