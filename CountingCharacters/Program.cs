using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Provide a text
            //string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Console.WriteLine("Enter text: ");
            string myString = (Console.ReadLine()).ToLower(); // Make case-insensitive
            
            char[] charactersInString = myString.ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the number of times each character occurs in text
            foreach (char c in charactersInString) {
                if (!char.IsLetter(c))
                {
                    continue;   // Exclude non-alphabetic characters
                }    
                else if (charCount.ContainsKey(c))
                    {
                    charCount[c] += 1;
                    }
                else
                {
                    charCount.Add(c, 1);
                }
            }

            // Print the results to the console
            foreach (KeyValuePair<char, int> chr in charCount) {
                Console.WriteLine(chr.Key + ": " + chr.Value);
            }
        }
    }
}
