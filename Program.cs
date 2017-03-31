//File: Program.cs
//Author: Marshall Chase Steely
//Purpose: Check a Sudoku puzzle.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPT_244_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] s = new int[9, 9] {
                { 2,1,5,6,4,7,3,9,8 },
                { 3,6,8,9,5,2,1,7,4 },
                { 7,9,4,3,8,1,6,5,2 },
                { 5,8,6,2,7,4,9,3,1 },
                { 1,4,2,5,9,3,8,6,7 },
                { 9,7,3,8,1,6,4,2,5 },
                { 8,2,1,7,3,9,5,4,6 },
                { 6,5,9,4,2,8,7,1,3 },
                { 4,3,7,1,6,5,2,8,9 }
            };

            Sudoku puzzle = new Sudoku();

            if(puzzle.isValid(s))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("\n" + "Not Valid");
            }
            Console.ReadKey();
        }

   
    }
}
