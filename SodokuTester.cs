//File: Program.cs
//Author: Marshall Chase Steely
//Purpose: Check a Sudoku puzzle.
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPT_244_Program_2
{
    public class Sudoku
    {
        int[,] block = new int[3, 3] {
                { 0,1,2 },
                { 3,4,5 },
                { 6,7,8 }
            };

        public bool isValid(int[,] s)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int num = 1; num <= 9; num++)
                    {
                        if (!testColumn(s, j, num))
                        {
                            
                            return false;
                        }
                        if (!testRow(s, i, num))
                        {
                           
                            return false;
                        }
                        if (!testSquare(s, i, j, num))
                        {
                            
                            return false;
                        }
                    }
              }
            }

            return true;

        }

        private bool testRow(int[,] s, int i, int num)
        {
            // check row
            int count = 0;
            for (int j = 0; j < 9; j++)
            {
                if (s[i, j] == num)
                {
                    count++;
                    bool isValid = count == 1;
                    if (!isValid)
                    {
                        Console.WriteLine("Failed At:\nRow {0}\nCol {1}\nNum {2}\nBlock {3}", i, j, num, getBlock(i,j));
                    }

                }
            }

            return count == 1; ;
        }

        private bool testColumn(int[,] s, int j, int num)
        {
            // check columns
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                    if (s[i, j] == num)
                { 
           
                       count++;
                    bool isValid = count == 1;
                    if (!isValid)
                    {
                        Console.Write("Failed At:\nRow {0}\nCol {1}\nNum {2}\nBlock {3}", i, j, num, getBlock(i, j));
                    }
                }
            }

            return count == 1;
        }

        private int getBlock(int i, int j)
        {
            int x = i / 3;
            int y = j / 3;
            return block[x, y];
        }


        private bool testSquare(int[,] s, int i, int j, int num)
        {
            // check block
            int count = 0;
            for (int row = i / 3 * 3; row < i / 3 * 3 + 3; row++)
            {
                for (int col = j / 3 * 3; col < j / 3 * 3 + 3; col++)
                {
                    if (s[row, col] == num)
                    {
                        count++;
                    }
                }
            }

            return count == 1;
        }

    }//END Sudoku
}//END namespace
