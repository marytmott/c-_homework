using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] testArr = {0, 0, 0, 0, 1, 1, 0, 0, 0, 3, 3, 3, 1, 1, 0};
            int testArrLength = testArr.Length;
            int[] smooshed = Lab2.smoosh(testArr);
            int smooshedArrLength = smooshed.Length;

            Console.WriteLine(testArrLength);
            Console.WriteLine(string.Join(",", smooshed));
            Console.WriteLine(smooshedArrLength);
        }
    }

    public class Lab2
    {
        /// <summary>
        /// smoosh() takes an array of ints. On completion the array contains
        /// the same numbers, but wherever the array had two or more consecutive
        /// duplicate numbers, they are replaced by one copy of the number.Hence,
        /// after smoosh() is done, no two consecutive numbers in the array are the
        /// same.
        ///
        /// Any unused elements at the end of the array are set to -1.
        ///
        /// For example, if the input array is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ],
        /// it reads[0 1 0 3 1 0 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1] after smoosh()
        /// completes.
        /// </summary>
        /// <param name="ints">the input array</param>
        public static int[] smoosh(int[] ints)
        {
            int inputLength = ints.Length;

            for (int i = 0; i < inputLength - 1; i++)
            {
                int k = ints[i];
                Console.WriteLine(k);
                // if duplicate is found
                if (ints[i] == ints[i + 1])
                {
                    for (int j = i; j < (inputLength - 1); j++)
                    {
                        ints[j] = ints[j + 1];
                    }

                    ints[inputLength - 1] = -1;
                }
            }
            return ints;
        }
    }
}