using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {

        public static string ReverseWordsInString(string input)
        {
            var result = input;

            // Validate Input
            if (!string.IsNullOrEmpty(input))
            {
                // Split into an array on ' ' and reverse
                // Rejoin the array
                result = String.Join(" ", input.Split(' ').Reverse());
            }

            return result;
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            var result = input;
            StringBuilder sb = new StringBuilder();

            // Validate Input
            if (!string.IsNullOrEmpty(input))
            {
                // Split on ' '
                string[] words = input.Split(' ');

                // Iterate over array in reverse
                // Append each word to the string builder 
                for (int i = words.Length - 1; i > -1; i--)
                {
                    sb.Append(words[i]).Append(' ');
                }

                result = sb.ToString().TrimEnd();
            }

            return result;
        }

        /// <summary>
        /// Bubble Sort
        /// Pass through the array multipe times 
        /// Swapping positions when the next index value is greater than
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {
            // Validate Input
            if (input != null)
            {
                int temp;

                // Make passes over the array for swapping value positions
                for (int pass = 0; pass < input.Length; pass++)
                {
                    // Iterate over the array
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        // Swap values if the next index is greater
                        if (input[i] > input[i + 1])
                        {
                            temp = input[i + 1];
                            input[i + 1] = input[i];
                            input[i] = temp;
                        }
                    }
                }
            }
            return input;
        }

        /// <summary>
        /// Selection Sort
        /// Pass through the array multipe times 
        /// Finding the minimum value in the array
        /// Comparing the current minimum with the current element
        /// Swapping if less.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static int[] SortWithoutUsingBuiltInSortMethodsBonus(int[] input)
        {
            // Validate Input
            if (input != null)
            {
                var arrayLength = input.Length;

                // Make passes over the array, to find the min value each pass
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    var smallestVal = i;
                    for (int j = i + 1; j < arrayLength; j++)
                    {
                        // if a smaller value is found 
                        // set the new min value
                        if (input[j] < input[smallestVal])
                        {
                            smallestVal = j;
                        }
                    }

                    // Swap with current index value with the new found min
                    var tempVar = input[smallestVal];
                    input[smallestVal] = input[i];
                    input[i] = tempVar;
                }
            }
            return input;
        }
    }
}
