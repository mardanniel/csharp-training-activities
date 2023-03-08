﻿namespace ActivityFive
{
    class Program
    {

        /**
            Q1: For any given sentance find the no of words in it.

            Q2: For any given sentance count the even length of words.

            Q3: Write a program to print all the words starting with s in this sentance.

            Q4: write a program to count the vowels in this sentance. [a,e,i,o,u]

            Q5: print all numbers which are even in between 1 to 100.
         */

        static void Main()
        {
            // TaskOne();
            // TaskTwo();
            // TaskThree();
            // TaskFour();
            // TaskFive();
        }

        static void TaskOne()
        {
            string input = "";
            Console.WriteLine("Enter sentence: ");
            input = Console.ReadLine();
            int numberOfWords = input.Split(" ").Length;
            Console.WriteLine($"Number of words in the sentence: {numberOfWords}");
        }

        static void TaskTwo()
        {
            string input = "";
            Console.WriteLine("Enter sentence: ");
            input = Console.ReadLine();
            string[] wordsIntSentence = input.Split(" ");
            var evenLengthWords = wordsIntSentence
                .ToList()
                .FindAll(x => x.Length % 2 == 0);
            Console.WriteLine($"Number of even length words in the sentence: {evenLengthWords.Count}");
        }

        static void TaskThree()
        {
            string input = "";
            Console.WriteLine("Enter sentence: ");
            input = Console.ReadLine();
            string[] wordsIntSentence = input.Split(" ");
            var wordsStartingWithS = wordsIntSentence
                .ToList()
                .FindAll(x => x[0].ToString().ToLower() == "s");
            Console.WriteLine($"Words starting with S in the sentence:");
            foreach( var word in wordsStartingWithS )
            {
                Console.WriteLine(word.ToString());
            }
        }

        static void TaskFour()
        {
            string input = "";
            Console.WriteLine("Enter sentence: ");
            input = Console.ReadLine();
            int vowelCountInTheSentence = input
                .Count(letter => "aeiou".Contains(Char.ToLower(letter)));
            Console.WriteLine($"Number of vowels in the sentence: {vowelCountInTheSentence}");
        }

        static void TaskFive()
        {
            Action<int> PrintEvenNumbers = x =>
            {
                int i = 1;
                while (i <= x)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                    i++;
                }
            };

            int max = 100;
            Console.WriteLine($"Even numbers from 1 to {max}:");
            PrintEvenNumbers(max);
        }
    }
}