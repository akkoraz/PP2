using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Users\Asus\Desktop\PP2\Week 2\Task4\Task4\bin\Debug\input.txt";
            string path1 = @"C:\Users\Asus\Desktop\PP2\Week 2\Task4\Task4\bin\Debug\Labs\input.txt";
            //System.IO.File.Create(path);
            System.IO.File.Move(path, path1);
        }
    }
}
