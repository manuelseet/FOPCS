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
            
            // 
            int uMark = -1 ;
            do
            {
                try
                {
                    Console.Write("Please enter your grade (in integer form): ");
                    uMark = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Grade must be in an integer form between 0 and 100!");
                }

            }
            while (uMark < 0 || uMark > 100 );

            string grade = null;
            if (uMark >= 80 && uMark <= 100)
                grade = "A";
            else if (uMark >= 60 && uMark <= 79)
                grade = "B";
            else if (uMark >= 40 && uMark <= 59)
                grade = "C";
            else if (uMark >= 0 && uMark <= 39)
                grade = "F";
            else
                grade = "**Error**";

                Console.WriteLine($"You scored {uMark} marks which is a(n) {grade} grade.");
            

            //4


            double minCharge = 2.40;
            double minDist = 0.5;
            double firstRate = 0.04;
            double firstDistThresh = 8.5;
            double PerDistance = 0.1;
            double secondRate = 0.05;

            Console.WriteLine("Fare conversion calculator");
            Console.Write("Pleae enter your distance");
            double uDist = Double.Parse(Console.ReadLine())*10;
            double Dist = Math.Round(uDist)/10;
            double finalCharges = 0;

            if (Dist > 0)
            {
                finalCharges += minCharge;
                Console.WriteLine(finalCharges);
            }

            if (Dist > minDist && Dist <= firstDistThresh+minDist)
            {
                Dist -= minDist;
                double firstIntervals = Dist / PerDistance;
                finalCharges += firstIntervals * firstRate;
                Console.WriteLine(finalCharges);

            }

            if (Dist > firstDistThresh + minDist)
            {
                Dist -= firstDistThresh + minDist;
                double secondInterval = Dist / PerDistance;
                finalCharges += secondInterval * secondRate;
                Console.WriteLine(finalCharges);

            }


            Console.WriteLine($"Your distance was {uDist}, rounded up to {Dist}. Your fare is {finalCharges}");

            

            //5
            int uNum = 0;
            do
            {
                Console.Write("Please enter a three digit number: ");
                uNum = Convert.ToInt32(Console.ReadLine());
            }
            while (uNum < 100 && uNum >999);

            

            double ones = uNum % 10;
            double tens = ((uNum - ones) / 10) % 10; 
            double hund = (uNum - tens*10 - ones) / 100;
            Console.WriteLine($"{ones}, {tens}, {hund}");

            double armstrongSum = Math.Pow(ones, 3.0) + Math.Pow(tens, 3.0) + Math.Pow(hund,3.0); 

            if (armstrongSum == uNum)
            {
                Console.WriteLine($"Your number {uNum} is an armstrong number");
            }
            else
            {
                Console.WriteLine($"Your number {uNum} is NOT an armstrong number");
            }





        }

    }
}
