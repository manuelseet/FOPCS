using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class Program
    {
        static void Main(string[] args)
        {

			int[,] arr2D = new int[,] { { 35, 82 }, { 67, 45 }, { 62, 77 } };

			for (int i = 0; i < arr2D.GetLength(0); i++)
			{
				for (int j = 0; j < arr2D.GetLength(1); j++)
				{
					Console.WriteLine($"In row {i}, {j}-th elem is {arr2D[i,j]}");
				}
			}
		}
    }
}
