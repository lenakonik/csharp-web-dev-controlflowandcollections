using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static int sumEven(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        static void printFiveLetters(List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void printXLetterWords(int x, List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == x)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            int total = sumEven(numbers);
            Console.WriteLine(total);


            string fruits = "Apple, Banana, Kiwi, Fruit";
            string fruit = fruits.Replace(" ", "");
            // Convert string to List
            List<string> words = fruit.Split(',').ToList();

            Console.WriteLine("How many letters you want to search: ");
            int x = int.Parse(Console.ReadLine());
            printXLetterWords(x, words);


        }
    }
}
