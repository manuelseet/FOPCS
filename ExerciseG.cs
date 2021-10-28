using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseG
    {
        static void Main(string[] arg)
        {
            
            //1
            int[] sales = new int[12] { 12, 13, 14, 15, 16, 17, 18, 10, 12, 14, 16, 17 };
            PrintMaxMonth(sales); PrintMinMonth(sales); PrintAvgSales(sales);


            //2
            int[] nums = new int[] { 1000, 45, 64, 12, 65, 75,12, 444 };
            //BubbleSort(nums);

            //3
            int[,] marks = new int[12, 4]
            {
                {56, 84, 68, 29 },
                {94, 73, 31, 96 },
                {41, 63, 36, 90 },
                {99, 9, 18, 17 },
                {62, 3, 65, 75 },
                {40, 96, 53, 23 },
                {81, 15, 27, 30 },
                {21, 70, 100, 22 },
                {88, 50, 13, 12 },
                {48, 54, 52, 78 },
                {64, 71, 67, 25 },
                {16, 93, 46, 72 },
            };

            PrintTotalMark(marks);
            PrintClassAverage(marks);


        }

        public static void PrintTotalMark(int[,] marks)
        {
            int studentN = marks.GetLength(0);
            int subjectN = marks.GetLength(1);

            for(int N = 0; N < studentN; N++)
            {
                int totalMark = 0;
                for(int sub = 0; sub < subjectN; sub++)
                {
                    totalMark += marks[N, sub];
                }

                double stuAvg = totalMark / subjectN;
                Console.WriteLine("Student {0} has total mark = {1}, avg = {2}", N, totalMark, stuAvg);
            }
        }
        public static void PrintClassAverage(int[,] marks)
        {
            int studentN = marks.GetLength(0);
            int subjectN = marks.GetLength(1);

            for (int sub = 0; sub < subjectN; sub++)
            {
                double subAvg = 0;
                for (int N = 0; N < studentN; N++)
                {
                    subAvg += marks[N, sub];
                }

                subAvg = subAvg / studentN;

                double SS = 0;
                for (int N = 0; N < studentN; N++)
                {
                    SS += Math.Pow(marks[N, sub] - subAvg, 2);
                }
                double subSD = Math.Sqrt(SS / studentN);

                Console.WriteLine("Subject {0} has class average mark = {1}, SD = {2}", sub, subAvg, subSD);
            }
        }

        

        public static int[] BubbleSort(int[] nums)
        {
            //printArr(nums);
            for(int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[i] > nums[j+i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j+i];
                        nums[j+i] = temp;

                        //printArr(nums);

                    }
                }

            }

            //printArr(nums);
            return nums;

        }

        public static void printArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }

        public static void PrintMaxMonth(int[] sales)
        {
            string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int index = Array.IndexOf(sales, sales.Max());
            Console.WriteLine($"Max sales month is {months[index]} with sales of ${sales.Max()}");
        }

        public static void PrintMinMonth(int[] sales)
        {
            string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int index = Array.IndexOf(sales, sales.Min());
            Console.WriteLine($"Min sales month is {months[index]} with sales of ${sales.Min()}");
        }

        public static void PrintAvgSales(int[] sales)
        {
            double avg = sales.Average();
            Console.WriteLine("The average sales of the year is {0}", avg);

        }
    }
}
