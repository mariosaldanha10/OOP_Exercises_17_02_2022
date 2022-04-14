using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercises_17_02_2022.Exercises
{
   public class Question3
    {
        static void SummingNumbers()
        {
            int[] myArray = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            Console.WriteLine("===================================================");

            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20, 25);
            Sum(myArray);
            Sum(5, 10, 15, 20, 25, 30, 35, 40, 45, 50);

            Console.WriteLine("\n=================================================");
        }
        static void Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of [{string.Join(", ", numbers)}] is {sum}.");
        }
    }
}

