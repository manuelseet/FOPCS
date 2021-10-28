using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Revision
{
    class ExerciseF
    {
        static void Main(string[] arg)
        {
            /*
            //1 a and b
            Console.Write("Please enter your string: ");
            string uPhrase = Console.ReadLine();
            Console.WriteLine($"There are {VowelCounter(uPhrase)} vowels in the phrase \"{uPhrase}\"");
            IndividualVowelCounter(uPhrase);
            

            //2
            Console.Write("Please enter your phrase: ");
            string uPhrase2 = Console.ReadLine();
            isPalindrome(uPhrase2);
            //3
            isPalindromeSkipSpace(uPhrase2);


            //4
            Console.Write("Enter a phrase to convert to title case: ");
            string uPhrase3 = Console.ReadLine();
            string titlePhrase = ConvertToTitleCase(uPhrase3);
            Console.WriteLine(titlePhrase);


            //5
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            PrintStudentReports(names, marks);

            */
            //6
            Console.WriteLine(CheckMatricNumber("A56742A"));
            Console.WriteLine(CheckMatricNumber("A56742S"));

            //bonus
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //if (letters.Any(uPhrase2.Contains))
            {
                //Console.WriteLine("yes");
            }
        }

        public static string CheckMatricNumber(string matric)
        {
            if (matric.Length != 7)
                return "Invalid";
            else
            {
                matric = matric.ToUpper();
            }

            char[] letters = "OPQRS".ToCharArray();
            if ( matric[0] != 'A' && (!letters.Any(matric[6].ToString().Contains)))
            {
                return "Invalid";
            }

            int checksum = 0;

            for(int i = 1; i <= 5; i++)
            {
                try
                {
                    checksum += Convert.ToInt32(matric[i]) * (7 - i);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Does not contain number in the {0} position!", i);
                    return "Invalid";
                }
                
            }

            checksum = checksum % 5;
            if (matric[6] != letters[checksum])
                return "Invalid";
            else 
                return "Valid";

        }

        public static void PrintStudentReports(string[] names, int[] marks)
        {
            if (names.Length != marks.Length)
            {
                throw new ApplicationException("the two arrays are not of equal length!");
            }

            //Marks sorting
            int[] sortedMarks = ExerciseG.BubbleSort(marks);

            string[] namesByMarks = new string[names.Length];
            for(int i = 0; i< names.Length; i++)
            {
                int ind = Array.IndexOf(sortedMarks, marks[i]);
                namesByMarks[i] = names[ind];
            }

            Console.WriteLine("Student Report , ranked by Marks");
            Console.WriteLine("Student Name \t\t Marks");
            for(int j = 0; j< namesByMarks.Length; j++)
            {
                Console.WriteLine($"{namesByMarks[j]} \t\t {sortedMarks[j]} ");

            }

            //Marks sorting
            string[] sortedNames = BubbleSortString(names);

            int[] marksByNames = new int[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                int ind = Array.IndexOf(sortedNames, names[i]);
                marksByNames[i] = marks[ind];
            }

            Console.WriteLine("Student Report , ranked by Name");
            Console.WriteLine("Student Name \t\t Marks");
            for (int j = 0; j < namesByMarks.Length; j++)
            {
                Console.WriteLine($"{sortedNames[j]} \t\t {marksByNames[j]} ");

            }

        }

        public static string[] BubbleSortString(string[] nums)
        {
            //printArr(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[i].CompareTo(nums[j + i])==1)
                    {
                        string temp = nums[i];
                        nums[i] = nums[j + i];
                        nums[j + i] = temp;

                        //printArr(nums);

                    }
                }

            }

            //printArr(nums);
            return nums;

        }

        public static string ConvertToTitleCase(string phrase)
        {
            string[] words = phrase.Split();
            string titlePhrase = "";
            foreach(string word in words)
            {
                string titleWord = word.Substring(0, 1).ToUpper() + word.Substring(1);
                titlePhrase = titlePhrase + titleWord + " ";
            }

            titlePhrase = titlePhrase.Substring(0, titlePhrase.Length - 1);


            return titlePhrase;
        }

        public static void isPalindrome(string phrase)
        {
            int len = phrase.Length;
            bool isPalind = true;
            for(int i = 0; i < len; i++)
            {
                if (phrase[i] == phrase[len - i -1]) //take note about string indexing, should be minus 1
                    continue;
                else
                    isPalind = false;

            }

            if (isPalind == false)
            {
                Console.WriteLine($"the phrase {phrase} is NOT a palindrome");
            }
            else
                Console.WriteLine($"the phrase {phrase} is a palindrome");
        }
        public static void isPalindromeSkipSpace(string phrase)
        {
            int len = phrase.Length;
            bool isPalind = true;

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


            string lowerPhrase = phrase.ToLower();

            int start = 0;
            int end = len - 1;
            for (int i = 0; i < len; i++)
            { 
                while (!letters.Any(lowerPhrase.Substring(start, 1).Contains))
                {
                    start++;
                    Console.WriteLine($"forced moved {start}");
                }

                while (!letters.Any(lowerPhrase.Substring(end, 1).Contains))
                {
                    end--;
                    Console.WriteLine($"forced moved {end}");

                }

                if (lowerPhrase[start] == lowerPhrase[end]) //take note about string indexing, should be minus 1
                    continue;
                else
                    isPalind = false;


            }

            if (isPalind == false)
            {
                Console.WriteLine($"the phrase {phrase} is NOT a palindrome");
            }
            else
                Console.WriteLine($"the phrase {phrase} is a palindrome");
        }

        public static int VowelCounter(string phrase)
        {
            int len = phrase.Length;
            int vCount = 0;


            for (int i = 0; i < len; i++)
            {
                string substr = phrase.Substring(i, 1).ToLower();

                if (substr == "a" || substr == "e" || substr == "i" || substr == "o" || substr == "u")
                {
                    vCount++;
                }

            }

            return vCount;
        }

        public static void IndividualVowelCounter(string phrase)
        {
            int len = phrase.Length;
            int aCount = 0; 
            int eCount =0;
            int iCount = 0;
            int oCount = 0;
            int uCount = 0;

            for (int i = 0; i < len; i++)
            {
                string substr = phrase.Substring(i, 1).ToLower();

                switch(substr)
                {
                    case "a":
                        aCount++; break;
                    case "e":
                        eCount++; break;
                    case "i":
                        iCount++; break;
                    case "o":
                        oCount++; break;
                    case "u":
                        uCount++; break;
                }

            }

            Console.WriteLine($"Vowel counts: {aCount} A's, {eCount} E's, {iCount} I's, {oCount} O's, {uCount} U's in the phrase \"{phrase}\"");
        }
    }
}
