using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[,] arr2 = { { 1, 2 }, { 3, 4 } };
            for(int i=0; i<arr1.Length; ++i)
            {
                arr1[i] = int.Parse(Console.ReadLine());
    
            }
            for(int i=0; i<arr1.Length; ++i)
            {
                Console.WriteLine(arr1[i]+5);
            }
            Console.WriteLine();
        }
    }
}
