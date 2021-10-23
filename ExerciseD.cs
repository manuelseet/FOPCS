using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseD
    {
        static void Main(string[] arg)
        {
            /*
            //1 
            int input = 0;
            while (input != 88)
            {
                Console.Write("Enter an integer: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Lucky you!");
            

            //2

            Console.Write("Enter input 01: ");
            int input01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter input 02: ");
            int input02 = Convert.ToInt32(Console.ReadLine());

            //assign two variables to hold values as they are iterated down to HCF
            int a = input01;
            int b = input02;

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            int HCF = a;
            int LCM = (input01 * input02) / HCF;

            Console.WriteLine($"for inputs {input01} and {input02}, HCF = {HCF} and LCM = {LCM}");
            */
            //3a
            
            Random rnd = new Random();
            int compNum = rnd.Next(0, 10);
            Console.WriteLine("I'm thinking of a number, can you guess what it is?");

            int uGuess = -1;// some filler number outside of range
            int counter = 0; // set counter as zero, to be incremented with each guess

            do
            {
                if (counter > 0)
                    Console.WriteLine("Try again...");
                Console.Write("Please enter your guess: ");
                uGuess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            while (uGuess != compNum);

            if (counter <= 2)
                Console.Write("You are a wizard! Congratulations! ");
            else if (counter >= 3 && counter <= 5)
                Console.Write("You make good guesses! ");
            else
                Console.Write("You are lousy! ");

            Console.WriteLine($"You took {counter} attempt(s) to guess my number {compNum}");

        }

    }
}
