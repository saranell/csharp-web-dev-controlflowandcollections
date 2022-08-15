﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> wordList = new List<string>();
            string[] words = sentence.Split(" ");
            foreach (string word in words)
            {
                wordList.Add(word);
            }

            Console.WriteLine(string.Join("/", words));
            
         }
    }
}

           