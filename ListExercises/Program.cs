using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a static method to find the sum of all the even numbers in a List.
            //Within Main, create a list with at least 10 integers and call your method on the list.
            List<int> nums = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            Console.WriteLine(SumEven(nums));

            static int SumEven(List<int> arr)
            {
                int total = 0;
                foreach (int integer in arr)
            {
                if (integer % 2 == 0)
                {
                    total += integer;
                }
            }
            return total;
}
            //Write a static method to print out each word in a list that has exactly 5 letters.
            public static void FiveLetterWords(List<string> wordList)
            {
                foreach (string word in wordList)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            Console.WriteLine(FiveLetterWords(wordList));

            //Modify your code to prompt the user to enter the word length for the search.
            public static void UserLetters(List<string> wordList, int length)
            {
                foreach (string word in wordList)
                {
                    if (word.Length == length)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            Console.WriteLine("Enter a word length: ");

            string lengthInput = Console.ReadLine();
            int numChars = int.Parse(lengthInput);

        }
    }

}