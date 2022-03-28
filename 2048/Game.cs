﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Helpers;

namespace _2048
{
    internal class Game
    {
        int fieldSize;
        int[,] field;
        bool isFinish;
        GameStep gameStep;

        public Game()
        {
            Init();
        }

        private void Init()
        {
            gameStep = new GameStep();
            fieldSize = 5;
            field = new int[fieldSize, fieldSize];

            GameStart();
        }

        private void GameStart()
        {
            while (!isFinish)
            {
                isFinish = gameStep.Step(fieldSize, field);
            }
            GameEnd();
        }

        private void GameEnd()
        {
            Console.WriteLine("Чтобы сыграть еще раз нажмите любую клавишу");
            Console.ReadKey();
            Init();
        }

        
    }
}