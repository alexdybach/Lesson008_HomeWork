using System;
using System.Text;

namespace Lesson008_HW4
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int[] array1 = new int[array.Length];
            int i = 0, j = array.Length - 1;
            while (i < array.Length)
            {
                array1[i] = array[j];
                j--;
                i++;
            }
            return array1;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];
            int j = 0, i = index;
            //for (int i = index; i < count; i++)
            while(j<count)
            {
                //if (i >= array.Length - index)
                
                if (i < array.Length)
                {
                    newArray[j] = array[i];                    
                }
                else
                {
                    newArray[j] = 1;
                }
                j++;
                i++;
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
                myArray[i] = random.Next(2, 20);
                Console.Write($"{myArray[i]}  ");
            }
            Console.WriteLine();

            Console.WriteLine("Інвертований масив :");
            int[] reversArr = MyReverse(myArray);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{reversArr[i]}  ");
            }
            Console.WriteLine();

            Console.WriteLine("Введіть початковий індекс нового масиву та його розмір :");
            int index = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Частина від масиву :");
            int[] partArr = SubArray(myArray, index, count);
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{partArr[i]}  ");
            }
            Console.WriteLine();
        }
    }
}
