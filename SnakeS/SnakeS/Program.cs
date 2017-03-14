﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeS
{
    class Program
    {

        static void Main(string[] args)
        {
            Game.Init();

            Console.CursorVisible = false;
            Console.SetWindowSize(70, 25);
            
            while (!Game.GameOver)
            {
                Game.Draw();
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.snake.Move(0, -1);
                        Console.Clear();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.snake.Move(0, 1);
                        Console.Clear();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.snake.Move(-1, 0);
                        Console.Clear();
                        break;
                    case ConsoleKey.RightArrow:
                        Game.snake.Move(1, 0);
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        Game.GameOver = true;
                        break;
                    case ConsoleKey.F2:
                        Game.Serialize();
                        Console.Clear();
                        break;
                    case ConsoleKey.F3:
                        Game.Derialize();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
  