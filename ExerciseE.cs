using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseE
    {
        static void Main(string[] arg)
        {
            //1
            
            Console.Write("Please enter an integer: ");
            int uNum1 = Convert.ToInt32(Console.ReadLine());

            int incFact = 1;
            int decFact = 1;

            for (int i = 1; i<= uNum1; i++)
            {
                incFact *= i;
            }

            for(int j = uNum1; j > 0; j--)
            {
                decFact *= j;
            }


            Console.WriteLine($"Factorial of {uNum1} is {incFact} and {decFact}");
            if (decFact == incFact)
            {
                Console.WriteLine("Both methods give the same results");
            }
            


            //2
            Console.WriteLine("No\t\tInverse\t\tSqRT\t\tSquare");
            Console.WriteLine("-----------------------------------------------------------");
            
            for(double i = 1; i <= 10; i++)
            {
                double inv = 1 / i;
                double sqrt = Math.Sqrt(i);
                double sq = Math.Pow(i, 2);
                Console.WriteLine($"{i: #.0}\t\t{inv: 0.0##}\t\t{sqrt: #.0##}\t\t{sq: #.0}");
            }

            //3
            Console.Write("Enter a positive integer number: ");
            int uNum2 = Convert.ToInt32(Console.ReadLine());
            if (PrimeNoChecker(uNum2))
            {
                Console.WriteLine($"{uNum2} is Prime");
            }
            else
                Console.WriteLine($"{uNum2} is NOT Prime");

            //4
            Console.Write("Enter a positive integer number: ");
            int uNum3 = Convert.ToInt32(Console.ReadLine());
            if (PerfectNoChecker(uNum3))
            {
                Console.WriteLine($"{uNum3} is Perfect");
            }
            else
                Console.WriteLine($"{uNum3} is NOT Perfect");


            //5
            for (int q = 0; q<=1000; q++)
            {
                if (PrimeNoChecker(q))
                    Console.Write($"{q} ");
            }


            Console.WriteLine();

            //6
            for (int q = 1
                ; q <= 10000; q++)
            {
                if (PerfectNoChecker(q))
                    Console.Write($"{q} ");
            }



        }

        public static bool PrimeNoChecker(int num)
        {
            bool IsPrime = true;

            if (num % 2 == 0 || num == 1)
            {
                IsPrime = false; 
            }
            else
            { 
                for (int i = 3; i < num; i+=2)
                {
                    if (num % i != 0)
                        continue;
                    else
                    {
                        IsPrime = false;
                        break;
                    }    
                        
                }
            }

            return IsPrime;
        }

        public static bool PerfectNoChecker(int num)
        {
            bool IsPerfect = false;

            int factorSum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    factorSum += i;
            }

            if (factorSum == num)
                IsPerfect = true;

            return IsPerfect;
        }
    }
}
