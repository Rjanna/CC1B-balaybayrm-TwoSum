using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1B_Balaybay_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you would like to input: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[max];
            Console.WriteLine("----------------------");

            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write("Number input: ");
                int num = Convert.ToInt32(Console.ReadLine());
                arr[x] = num;
            }
            bool TwoSum = false;
            Console.WriteLine("----------------------");
            Console.Write("Target Number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        TwoSum = true;
                        Console.WriteLine($"Output: [{i},{j}]");
                        break;
                    }
                }
                if (TwoSum)
                {
                    break;
                }
            }

            if (!TwoSum)
            {
                Console.WriteLine("Output: No solution");
            }
        }
    }
}
