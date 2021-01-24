using System;
using System.Collections.Generic;

namespace arrayAndList
{
    class Program
    {
        static void Main()
        {
            int[] thisArray = new int[10];

            Console.WriteLine("The array length of: " +
                                 thisArray.Length);

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);    
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
