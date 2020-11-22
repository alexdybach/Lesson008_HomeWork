using System;
using System.Text;

namespace Lesson008_HW3
{
    class Program
    {
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
                myArray[i] = random.Next(0, 20);
                Console.Write($"{myArray[i]}  ");
            }
            Console.WriteLine();
            int max, min, suma = 0;
            double average;
            min = myArray[0];
            max = myArray[0];
            for (int i = 0; i < n; i++)
            {
                if (myArray[i] < min)
                    min = myArray[i];
                if (myArray[i] > max)
                    max = myArray[i];
                suma += myArray[i];                
            }
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"suma = {suma}");
            average = (double)suma / n;
            Console.WriteLine($"average = {average}");
        }
    }
}
