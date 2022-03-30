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
        
        readonly Random random = new Random();
        int fieldSize;
        int[,] field;
        MoveCalculation moveCalculation = new MoveCalculation();

        public GameStep(int fieldSize, int[,] field)
        {
            this.fieldSize = fieldSize;
            this.field = field;
        }

        public bool Step()
        {
            fieldCreate();
            keysChecking();
            generateDigit();

            return false;
        }

        public void fieldCreate()
        {
            //var pads = Helper.GetMaxValFromArr(field).ToString().Length;

            for (int i = 0; i < fieldSize; i++)
            {
                Console.WriteLine(new string('-', 5 * fieldSize));
                Console.Write("|");
                for (int k = 0; k < fieldSize; k++)
                {
                    if (field[i,k] == 0)
                    {
                        Console.Write(string.Format($" |".PadLeft(5), fieldSize));
                    }
                    else
                    {
                        Console.Write(string.Format($" {field[i, k].ToString().PadLeft(3)}|", fieldSize));
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 5 * fieldSize));
        }

        public int[,] generateDigit()
        {
            bool qnic;
            do
            {
                int i = random.Next(0, fieldSize);
                int k = random.Next(0, fieldSize);

                int x;
                if (random.NextDouble() < 0.9)
                    x = 2;
                else
                    x = 4;

                qnic = true;
                if (field[i,k] == 0)
                {
                    field[i,k] = x;
                    qnic = false;
                }
            } while (qnic);

            
            return field;
        }

        //СЧИТЫВАНИЕ КЛАВИШ ОТ ПОЛЬЗОВАТЕЛЯ ПРИ ВХОДЕ
        public int[,] keysChecking()
        {
            ConsoleKeyInfo key = Console.ReadKey(false);
 
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    return moveCalculation.Up(field, fieldSize);
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    return moveCalculation.Down(field, fieldSize);
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    return moveCalculation.Left(field, fieldSize);
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    return moveCalculation.Right(field, fieldSize);
                default:
                    Console.WriteLine(" - не подходящий символ. Используйте стрелки");
                    return keysChecking();
            }
        }
    }
}
