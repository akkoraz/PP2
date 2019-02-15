using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolichestvo = int.Parse(Console.ReadLine());//quantity row
            for(int i=0;i<kolichestvo;i++)// cycle of row
            {
                for (int j = 0; j <= i; j++) //cycle of string 
                    Console.Write("[*]");//every next string will be increase on one*/
                Console.WriteLine();

            }
        }
    }
}
