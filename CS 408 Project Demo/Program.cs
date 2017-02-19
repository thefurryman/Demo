using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_408_Project_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by commas.");
            string input = Console.ReadLine();
            string[] tokens = input.Split(',');

            int[] nums = stringParser(tokens);
            nums = useRandomSort(nums);
           
            print(nums);
            Console.ReadLine();
        }

        public static int[] useRandomSort(int[] input)
        {
            Random rand = new Random();
            int rNum = rand.Next(0, 2);
            if (rNum == 0)
            {
                input = insertionSort(input);
                Console.WriteLine("insertion sort");
            }
            else
            {
                input = bubbleSort(input);
                Console.WriteLine("bubble sort");
            }
            return input;

        }
        public static int[] stringParser(string[] strArr)
        {
            int[] nums = new int[strArr.Length];
            int newInt;

            for (int i = 0; i < strArr.Length; i++)
            {
                string s = strArr[i];
                if (Int32.TryParse(s, out newInt))
                {
                    nums[i] = newInt;
                }
            }
            return nums;
        }

        public static void print(int[] input)
        {
            foreach (int s in input)
            {
                Console.Write(s.ToString() + " ");
            }
        }

        public static int[] insertionSort(int[] input)
        {
            int temp;
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                }
            }
            return input;
        }

        public static int[] bubbleSort(int[] input)
        {
            int n = input.Length;
            int k;
            for (int m = n; m >= 0; m--)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    k = i + 1;
                    if (input[i] > input[k])
                    {
                        int temp = input[i];
                        input[i] = input[k];
                        input[k] = temp;
                    }
                }
            }
                return input;
        }
    }
}
