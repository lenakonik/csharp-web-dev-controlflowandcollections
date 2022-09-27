using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            //Loop through the array and print out each value
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            //Print the odd numbers from the array
            for (int i = 1; i < myArray.Length; i+= 2)
            {
                Console.WriteLine(myArray[i]);
            }


        }
    }
}
