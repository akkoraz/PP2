using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            //string z= Console.ReadLine();
            bool isTrue = false;
            if (x > 4)
            {
                isTrue = true;
            }
            if (isTrue) Console.WriteLine("Number " + x + " more than 4");
            Console.ReadKey();
        }
    }
}
