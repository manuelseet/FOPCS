using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseC
    {
        static void Main(string[] arg)
        {
            //1 
            Console.Write("Please enter your name: ");
            string uName1 = Console.ReadLine();
            Console.Write("Please enter your gender(M/F): ");
            string uGender = Console.ReadLine();
            string salutation = "Mr.";
            if (uGender == "F")
                salutation = "Ms.";
            Console.WriteLine($"Good morning {salutation} {uName1}");


            //2
            Console.Write("Please enter your name: ");
            string uName2 = Console.ReadLine();
            Console.Write("Please enter your gender(M/F): ");
            string uGender2 = Console.ReadLine();
            string salutation2 = "Mr.";
            if (uGender == "F")
                salutation = "Ms.";
            Console.WriteLine($"Good morning {salutation} {uName1}");
        }

    }
}
