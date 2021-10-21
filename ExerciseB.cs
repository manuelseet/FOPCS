using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseB
    {
        static void Main(string[] arg)
        {
            /*
            //1
            Console.Write("Enter a double precision number: ");
            double uNum1 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Sqrt(uNum1)}");

            //2
            Console.Write("Enter a double precision number: ");
            double uNum2 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Sqrt(uNum2): #.000}");

            //3
            Console.Write("Enter a salary: ");
            double salaryPlus = Convert.ToDouble(Console.ReadLine());
            salaryPlus = salaryPlus * 1.13;
            Console.WriteLine(salaryPlus.ToString("C2"));

            //4
            Console.Write("Enter a temperature in Centigrade: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double F = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} C = {F} F");

            //5 - skip

            */
            //6 - se String split
            Console.Write("Please enter 4 digits (x1, x2, y1, y2), separated by commas/spaces: ");
            string[] strSplit = Console.ReadLine().Split(new char[] { ',', ' '});
            double[] nums = new double[4];
            
            
            int j = 0;
            foreach (string i in strSplit)
            {
                nums[j] = Convert.ToDouble(i);
                Console.WriteLine(i);
            }

            double distance = Math.Sqrt(Math.Pow((nums[1] - nums[0]), 2) + Math.Pow((nums[3] - nums[2]), 2));
            Console.WriteLine("distance = {0}", distance);

        }


    }
}
