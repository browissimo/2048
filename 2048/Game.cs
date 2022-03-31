using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Helpers;

namespace _2048
{
    internal class Game
    {
        bool isFinish;
        GameStep gameStep;
        int[,] field;

        public Game()
        {
            Init();
        }

        private void Init()
        {
            isFinish = false;
            int fieldSize = 4;
            field = new int[fieldSize, fieldSize];
            gameStep = new GameStep(fieldSize, field);

            GameStart();
        }

        private void GameStart()
        {
            while (!isFinish)
            {
                isFinish = gameStep.Step();
            }
            GameEnd();
        }

        private void GameEnd()
        {
            gameStep.fieldCreate();
            Console.WriteLine();
            string score = Helper.GetMaxValFromArr(field).ToString();
            Console.WriteLine($"Вы набрали {score} очков\n");
            Console.WriteLine("Чтобы сыграть еще раз нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Init();
        }    
    }
}
