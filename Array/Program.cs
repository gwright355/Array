// Glenn Wright
// Array assignment
// ISM 4300



using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            foreach (int i in elements)

            {

                Console.WriteLine("Element Value = " + i);

            }

            Console.WriteLine("__________________________________");
            Console.WriteLine("");


            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey(true);

            


        }
    }
}
