using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal class MoveCalculation
    {
        public int[,] Up(int[,] field, int fieldsize)
        {
            for (int row = 0; row < fieldsize; row++)
            {
                for (int cell = 0; cell < fieldsize; cell++)
                { 
                    for (int prevCell = cell + 1; prevCell < fieldsize; prevCell++)
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

        public int[,] Down(int[,] field, int fieldsize)
        {
            for (int row = fieldsize - 1; row >= 0; row--)
            {
                for (int cell = fieldsize - 1; cell >= 0; cell--)
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

        public int[,] Right(int[,] field, int fieldsize)
        {
            for (int cell = fieldsize - 1; cell >= 0; cell--)
            {
                for (int row = fieldsize - 1; row >= 0; row--)
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

        public int[,] Left(int[,] field, int fieldsize)
        {
            for (int cell = 0; cell < fieldsize; cell++)
            {
                for (int row = 0; row < fieldsize; row++)
                {
                    for (int prevCell = cell + 1; prevCell < fieldsize; prevCell++)
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
