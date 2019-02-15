using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(@"CC:\Users\Asus\Desktop\PP2\Week 3\Task 1\Layer");
            Stack<Label> history = new Stack <Layer> ();
            history.Push(
                    new Layer
                    {
                        Content = root.GetFileSystemInfos().ToList(),
                        SelectedItem = 0
                    }
                );


            while (true)
            {
                history.Peek().Draw();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;
                        break;

                }
            }
        }
    }

    internal class Layer
    {
    }
}