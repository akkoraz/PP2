using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
        class Program
    {
        class university
        {
            public string name;
            public int id;
            }
        static void Main(string[] args)
        {
            university people = new university();
            people.name = "Akzhan";
            people.id = 123456789;
            for (int Y = 1; Y < 5; Y++)
            {
                Console.WriteLine("{0} {1} {2} ",people.name, people.id , Y);
            }
        }
           
    }
}
