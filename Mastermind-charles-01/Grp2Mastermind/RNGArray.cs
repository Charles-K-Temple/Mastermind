using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Mastermind
{
    class RNGArray
    {
        Random rng = new Random();

        public static int[] GenerateNumbers(int seed, int range, int choices)
        {
            Random rng = new Random(seed);
            int[] numbers = new int[choices];
            for (int i = 0; i < choices; i++)
            {
                numbers[i] = rng.Next(1, range+1);
            }
            return numbers;
        }

        /*
 * The following is mostly lifted from
 * http://stackoverflow.com/questions/22737687/how-to-create-an-array-of-non-repeating-random-numbers
 * with some design changes to suit our needs
 * 
 * */
        public static int[] GenerateNonRepeatingNumbers(int seed, int range, int choices)
        {
            // Make sure range is an appropriate value
            if (range <= 0)
            {
                throw new ArgumentException("Range must be greater than zero.");
            }

            // Make an array to hold our numbers
            int[] numbers = new int[range];
            int[] randomArray = new int[choices];

            // Seed the RNG.
            Random rng = new Random(seed);

            // Fill the array with all numbers from min to min + range
            for (int i = 0; i < range; numbers[i] = 1 + i++) { }

            int
                a = 0, // Swap index
                t = 0; // Temporary value storage

            // Scramble the values
            for (int i = 0; i < range; i++)
            {
                // Get a random index that isn't i
                while ((a = rng.Next(range)) == i) { };
                // Store the old value at i
                t = numbers[i];
                // Change the old value to the value at the random index
                numbers[i] = numbers[a];
                // Set value at random index to our old value from numbers[i]
                numbers[a] = t;
            }

            for (int i = 0; i < choices; i++)
            {
                randomArray[i] = numbers[i];
            }
            return randomArray;
        }



    }
}
