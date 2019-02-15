using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Layer
    {
        private int selectedItem;
        public int SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value >= Content.Count)
                {
                    selectedItem = 0;
                }
                else if (value < 0)
                {
                    selectedItem = Content.Count - 1;
                }
                else
                {
                    selectedItem = value;
                }
            }
        }

        public List<FileSystemInfo> Content
        {
            get;
            set;
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < Content.Count; ++i)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }

                else if (Content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;// file
                }
                Console.WriteLine(Convert.ToString(Convert.ToString(i + 1) + ". ") + Content[i].Name);
                Console.BackgroundColor = ConsoleColor.Black;


            }
        }
    }
}
