using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            // Split the string at each space and store the individual words in an array
            string[] words = s.Split();
            // Print the array of words 
            Console.WriteLine(string.Join(",", words));

            string[] sentences = s.Split(".");
            Console.WriteLine(string.Join(";", sentences));
        }
    }
}
