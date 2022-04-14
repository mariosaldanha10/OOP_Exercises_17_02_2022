using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercises_Week4.Exercises
{
    public class Question1
    {

        public Question1()
        {

        }
        static void main()
        {

            Console.Write("Enter an integer : ");
            string input = Console.ReadLine();
            int num;
            int.TryParse(input, out num); // returns num = 0 if input invalid
            Console.WriteLine();
            multiplicationTable(num);
            Console.ReadKey();

        }

        static void multiplicationTable(int num)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1, -2} = {2}", num, i, num * i);
            }
        }

    }
}

