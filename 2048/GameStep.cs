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

        public GameStep(int fieldSize, int[,] field)
        {
            this.fieldSize = fieldSize;
            this.field = field;
        }

        public bool Step()
        {
            field = plusMoveField();
            fieldCreate();
            keysChecking();

            return true;
        }

        //ОТРИСОВКА ПОЛЯ
        public void fieldCreate()
        {
            var pads = Helper.GetMaxValFromArr(field).ToString().Length;

            for (int i = 0; i < fieldSize; i++)
            {
                Console.WriteLine(new string('-', (pads + 2 )* fieldSize));
                Console.Write("|");
                for (int k = 0; k < fieldSize; k++)
                {
                    Console.Write(string.Format($" {field[i, k].ToString().PadLeft(pads)}|", fieldSize));
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', (pads + 2) * fieldSize));
        }

        //ГЕНЕРАЦИЯ 2 ИЛИ 4 В СОУЧАЙНОМ ПУСТОМ МЕСТЕ
        public int[,] plusMoveField()
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
        public int keysChecking()
        {
            ConsoleKeyInfo key = Console.ReadKey(false);
 
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    return 1;
                case ConsoleKey.DownArrow:
                    return 3;
                case ConsoleKey.LeftArrow:
                    return 4;
                case ConsoleKey.RightArrow:
                    return 2;
                default:
                    return -1;
            }
        }
    }
}
