using System;

namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = ReadNums();

            Console.WriteLine("Squares of a Sorted= " +nums);

        }

        public int[] SortedSquares(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            int left = 0;
            int right = n - 1;
            int square = 0;

            for (int i = n - 1; i >= 0; i --)
            {
                if(Math.Abs(nums[left]) < Math.Abs(nums[left]))
                {
                    square = nums[right];
                    right -= 1;
                }
                else
                {
                    square = nums[left];
                    left += 1;
                }
                result[i] = square * square;
            }

            return result;
        }

        private static int[] ReadNums()
        {
            Console.WriteLine("Enter nums length:");
            string length = Console.ReadLine();
            int numsLength = Int32.Parse(length);

            int[] nums = new int[numsLength];
            for (int i = 0; i < numsLength; i++)
            {
                Console.WriteLine("Enter nums " + i);
                string currentNumber = Console.ReadLine();
                nums[i] = Int32.Parse(currentNumber);
            }

            return nums;
        }
    }
}
