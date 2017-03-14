using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeS
{
    [Serializable]
    public class Game
    {
        public static bool GameOver;
        public static Snake snake;
        public static Food food;
        public static Wall wall;


        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            GameOver = false;

            // snake init
            List<Point> snake_body = new List<Point>();
            snake_body.Add(new Point(10, 10));
            snake_body.Add(new Point(9, 10));
            snake = new Snake(ConsoleColor.Yellow, '0', snake_body);

            // wall init
            List<Point> wall_body = new List<Point>();
            wall = new Wall(ConsoleColor.Red, '#', wall_body);


            // food init
            List<Point> food_body = new List<Point>();
            food_body.Add(new Point(0, 0));
            food = new Food(ConsoleColor.Green, '*', food_body);

            if (Game.snake.CanEat(Game.food))
            {
                Game.food.SetRandomPosition();
            }

            if (Game.snake.body.Count == 4)
            {
                Game.wall.LoadLevel(2);
            }
        }
        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }

        public static void Serialize()
        {
            Game.snake.Create();
            Game.wall.Create();
            Game.food.Create();
        }
        public static void Derialize()
        {
            Console.Clear();
            Game.snake.Resume();
            Game.wall.Resume();
            Game.food.Resume();

            Draw();
        }
    }
}
