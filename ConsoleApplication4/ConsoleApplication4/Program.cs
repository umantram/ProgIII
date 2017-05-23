using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before callinf the method, the first element is: {0}", arr[0]);
            Change(ref arr);
            Console.WriteLine("Inside Main, before callinf the method, the first element is: {0}", arr[0]);

            Console.ReadKey();

        }

        static void Change(ref int[] pArray) {

            pArray[0] = 888;
            pArray = new int[5] { -3, -2, -2, -3, -4 }; ;
            Console.WriteLine("Inside the method, the first element  is: {0}", pArray[0]);
        
        }
    }
}
