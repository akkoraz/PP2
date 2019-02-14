using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void clon() //creating method
        {
            string a = Console.ReadLine(); //input in string s
            int cnt = 0;
            string[] massiv = a.Split(' ');//input every number seperate string,sorted with hepls split(split seperates value every space)
            string[] massiv2 = new string[massiv.Length + massiv.Length];//create new array fot repeating numbers
            for (int i = 0; i < massiv.Length; i++) //cycle for from 0 to length of array
            {
                massiv2[cnt++] = massiv[i];//output value of array 2 times
                massiv2[cnt++] = massiv[i];
            }
            for (int j = 0; j < massiv2.Length; j++)
            {
                Console.Write("{0}", massiv2[j]);//output array with repeating numbers
            }
        }
        static void Main(string[]args)
        {
            clon();//call method
        }
    }
}
