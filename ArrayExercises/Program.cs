using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initialize an array with the following values in a single line:
            int[] nums = { 1, 1, 2, 3, 5, 8 };

            //Loop through the array and print out each value:
            foreach (int i in nums)
            {
                Console.WriteLine(i);

                //Modify the loop to only print the odd numbers from the array:
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        Console.WriteLine(nums[i]);
                    }
                }
            }

        }
    }
