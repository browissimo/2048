using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal class MoveCalculation
    {
        public int[,] Up(int[,] field)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int cell = 0; cell < 4; cell++)
                { 
                    for (int prevCell = cell + 1; prevCell < 4; prevCell++)
                    {
                        if (field[prevCell, row] != 0)
                        {
                            if (field[cell, row] == 0)
                            {
                                field[cell, row] = field[prevCell, row];
                                field[prevCell, row] = 0;
                            }
                            else
                            {
                                if (field[cell, row] == field[prevCell, row])
                                {
                                    field[cell, row] += field[prevCell, row];
                                    field[prevCell, row] = 0;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            return field;
        }

        public int[,] Down(int[,] field)
        {
            for (int row = 3; row >= 0; row--)
            {
                for (int cell = 3; cell >= 0; cell--)
                {
                    for (int prevCell = cell -1; prevCell >= 0; prevCell--)
                    {
                        if (field[prevCell, row] != 0)
                        {
                            if (field[cell, row] == 0)
                            {
                                field[cell, row] = field[prevCell, row];
                                field[prevCell, row] = 0;
                            }
                            else
                            {
                                if (field[cell, row] == field[prevCell, row])
                                {
                                    field[cell, row] += field[prevCell, row];
                                    field[prevCell, row] = 0;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            return field;
        }

        public int[,] Right(int[,] field)
        {
            for (int cell = 3; cell >= 0; cell--)
            {
                for (int row = 3; row >= 0; row--)
                {
                    for (int prevCell = cell - 1; prevCell >= 0; prevCell--)
                    {
                        if (field[row, prevCell] != 0)
                        {
                            if (field[row, cell] == 0)
                            {
                                field[row, cell] = field[row, prevCell];
                                field[row, prevCell] = 0;
                            }
                            else
                            {
                                if (field[row, cell] == field[row, prevCell])
                                {
                                    field[row, cell] += field[row, prevCell];
                                    field[row, prevCell] = 0;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            return field;
        }

        public int[,] Left(int[,] field)
        {
            for (int cell = 0; cell < 4; cell++)
            {
                for (int row = 0; row < 4; row++)
                {
                    for (int prevCell = cell + 1; prevCell < 4; prevCell++)
                    {
                        if (field[row, prevCell] != 0)
                        {
                            if (field[row, cell] == 0)
                            {
                                field[row, cell] = field[row, prevCell];
                                field[row, prevCell] = 0;
                            }
                            else
                            {
                                if (field[row, cell] == field[row, prevCell])
                                {
                                    field[row, cell] += field[row, prevCell];
                                    field[row, prevCell] = 0;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            return field;
        }
    }
}
