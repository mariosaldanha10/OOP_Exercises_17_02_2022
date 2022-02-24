using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercises_17_02_2022.Exercises
{
    public class Question2
    {
        static void typingNumber() 
        { 
            Console.Write("Type a number to square root : ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            squareNumber(x);
        }
        static void squareNumber(int x)
        {
            Console.WriteLine("The square root is : " + Math.Sqrt(x));

            Console.Write("Type a number to cubic root : ");
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            cubeNumber(y);
        }

        static void cubeNumber(int y)
        {
            Console.WriteLine("The cubic root is : " + Math.Cbrt(y));
        }
    }
}
