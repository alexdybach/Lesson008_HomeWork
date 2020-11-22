using System;

namespace Lesson008_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 8, 17, 6, 19, 4, 8, 13, 0 };
            for(int i=9;i>=0;i--)
            {
                Console.Write(myArray[i]+" ");
            }
        }
    }
}
