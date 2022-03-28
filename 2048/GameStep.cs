using _2048.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal class GameStep
    {
        public bool Step(int fieldSize, int[,] field)
        {
            fieldCreate(fieldSize, field);

            return true;
        }

        public void fieldCreate(int fieldSize, int[,] field)
        {
            var pads = Helper.GetMaxValFromArr(field).ToString().Length;

            for (int i = 0; i < fieldSize; i++)
            {
                Console.WriteLine(new string('-', (pads +2 )* fieldSize));
                Console.Write("|");
                for (int k = 0; k < fieldSize; k++)
                {
                    Console.Write(string.Format($" {field[i, k].ToString().PadLeft(pads)}|", fieldSize));
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', (pads + 2) * fieldSize));
        }
    }
}
