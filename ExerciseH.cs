using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseH
    {
        static void Main(string[] arg)
        {
            //1
            //ReadInteger();

            //2 
            int[] nums = new int[] { 1, 2, 3, 4, 5, 1, 2, 7, 8 };
            //PrintArray(nums);

            //3
            for(int i = 0; i<=100; i++)
            {
                //Console.WriteLine($"{i} = {HexConvert(i)}");
            }

            //4
            string word = "eoeoeoeoe";
            Console.WriteLine(Substitute(word, 'e', 'i'));

            //5


            //6

            //7
            for (int j = 1; j < 100; j++)
                if (IsPrime(j))
                    Console.Write($"{j} ");

            //8
            int[,] A = new int[1, 2] { { 1, 2 } };
            int[,] B = new int[2, 4] { {1,2,3,4 }, {1,2,3,4} };
            int [,] C = new int[1, 3] { { 1, 2, 3 } };
            int[,] result = MatrixMultiply(A, B);
            Console.WriteLine();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i,j]}\t");
                }
                Console.WriteLine();
            }
            int[,] result2 = MatrixMultiply(A, C);

            //9

        }


        public static int ReadInteger()
        {
            bool isInteger;
            int num = 0;
            do
            {
                isInteger = true;
                try
                {
                    Console.Write("Enter an integer here: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    isInteger = false;
                    Console.WriteLine("**Error: We only accept integers!**");

                }
                
            }
            while (isInteger == false);

            return num;
        }

        public static void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static string HexConvert(int num)
        { 
            string[] hex = new string[16] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E","f"};
            

            string hexNum;
            if (num < 16)
                hexNum = hex[num]; //use this to convert char to string
            else
            {
                int ones = num % 16;
                int tens =  (num - ones)/ 16;
                hexNum = hex[tens] + hex[ones];
            }

            return hexNum;
        }

        public static string Substitute(string str, char c1, char c2)
        {
            int len = str.Length;

            string[] wordFrag = str.Split(c1);

            string newStr = wordFrag[0];
            for (int i = 1; i < wordFrag.Length; i++)
            {
                newStr = newStr + c2.ToString() + wordFrag[i];
                
            }
            return newStr;
        }

        public static int[] SetArray(int[] arr, int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }

            return arr;
        }

        public static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newArr = new int[newSize];

            arr.CopyTo(newArr, 0);

            return newArr;
        }

        public static bool IsPrime(int n)
        {
            bool isP = true;

            if (n % 2 == 0 || n == 1 )
            {
                isP = false;
            }
            else
            {
                for (int i = 3; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isP = false;
                        break;
                    }
                    else
                        continue;
                        
                }
            }

            return isP;
        }


        public static int[,] MatrixMultiply(int[,] A, int [,] B)
        {
            int comDim = A.GetLength(1);
            if (comDim != B.GetLength(0))
            {
                throw new Exception("Given matrices are not compatible for matrix multiplication");
            }    
            
            int nRow = A.GetLength(0);
            int nCol = B.GetLength(1);
            
            int[,] mat = new int[nRow,nCol];


            for (int row = 0; row < nRow; row++)
            {
                for(int col = 0; col < nCol; col++)
                {
                    int cell = 0;
                    for(int s = 0; s < comDim; s++)
                    {
                        cell += A[row, s] * B[s, col];
                    }
                    mat[row, col] = cell;

                }

            }


            return mat;
        }

    }
}
