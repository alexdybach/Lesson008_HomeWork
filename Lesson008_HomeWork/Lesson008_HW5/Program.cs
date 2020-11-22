using System;
using System.Text;

namespace Lesson008_HW5
{
    class Program
    {
        static int[] EditArray(int[] array)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        static int[] EditArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть розмір масиву :");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            Random random = new Random();
            Console.WriteLine("Масив :");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = random.Next(5, 30);
                Console.Write($"{myArray[i]}  ");
            }
            Console.WriteLine();

            Console.WriteLine("Масив зі збільшеним на 1 розміром :");
            int[] editedArr1 = EditArray(myArray);
            for (int i = 0; i < editedArr1.Length; i++)
            {
                Console.Write($"{editedArr1[i]}  ");
            }
            Console.WriteLine();

            Console.WriteLine("Введіть число, щоб помістити його на початок масиву :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Масив зі збільшеним на 1 розміром та заміненим 0 елементом :");
            int[] editedArr2 = EditArray(myArray, number);
            for (int i = 0; i < editedArr2.Length; i++)
            {
                Console.Write($"{editedArr2[i]}  ");
            }
            Console.WriteLine();
        }
    }
}
