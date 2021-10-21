using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseA
    {
        static void Main(string[] arg)
        {
            //ExerciseA
            Console.WriteLine("Manuel");
            Console.WriteLine("e0838385@u.nus.edu");

            //2
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Good morning " + name);

            //3
            Console.Write("Please enter an integer ");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqNum = Math.Pow((double) num, 2.0);
            Console.WriteLine($"The square of {num} is {sqNum}");

            //bonus
            int num2 = 0;
            do
            {
                Console.Write("Please enter an even number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            while (num2 % 2 != 0);

            Console.WriteLine($"The square of {num2} is {Math.Pow(num2, 2.0)}");

            //5
            Console.Write("Enter a double precision number: ");
            double uNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The number you entered was {uNum} = {uNum: #.00}");



        }
    }
}
