using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarManager
{
    class State
    {
        private int index; //сначала создаем приватный, так как индекс у нас не должно быть отрицательным и не превышало максимальное количество
        public int Index
        {
            get { return index; } //если выполняется get , то возвращаем index
            set // если get не выполняется
            {
                int maxVal = Folder.GetDirectories().Length;  // максимальное значение равно количестве папок
                if (value >= 0 && value < maxVal)
                {
                    index = value; //если значение больше нуля и меньше максимального, то ндекс равно значению
                }
            }
        }
        public DirectoryInfo Folder { get; set; } //все те вышеуказанные условия выполняются и с папками
    }

    class Program
    {
        static void ShowFolderContent(State state)
        {
            Console.Clear();
            DirectoryInfo[] list = state.Folder.GetDirectories(); //возвращает данные, которые расположены в текущей папке  
            for (int i = 0; i < list.Length; ++i) //пробегаемся 
            {
                if (state.Index == i) //если индекс равно i
                {
                    Console.BackgroundColor = ConsoleColor.White; //цвет фона
                    Console.ForegroundColor = ConsoleColor.Black; //цвет самого текста
                }
                Console.Write(list[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            foreach (FileInfo f in state.Folder.GetFiles()) //просмотриваем все файлы
            {
                Console.WriteLine(f.Name);
            }
        }

        static void Main(string[] args)
        {
            bool alive = true;
            State state = new State { Folder = new DirectoryInfo(@"E:\")}; //создаем новый State, в которым мы создаем новый DirectoryInfo
            Stack<State> layers = new Stack<State>();
            layers.Push(state); // Push указывает папку, которая находится под индексом 0
            while (alive)
            {
                ShowFolderContent(layers.Peek());
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        layers.Peek().Index--;
                        break;
                    case ConsoleKey.DownArrow:
                        layers.Peek().Index++;
                        break;
                    case ConsoleKey.Escape:
                        layers.Pop();
                        break;
                    case ConsoleKey.Enter:
                        DirectoryInfo[] list = layers.Peek().Folder.GetDirectories();
                        State newState = new State
                        {
                            Folder = new DirectoryInfo(list[state.Index].FullName),
                            Index = 0
                        };
                        layers.Push(newState);
                        break;
                }

            }
        }
    }
}
