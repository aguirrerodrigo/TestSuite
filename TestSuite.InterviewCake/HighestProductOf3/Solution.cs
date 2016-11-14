using System;

namespace TestSuite.InterviewCake.HighestProductOf3
{
    public static class Solution
    {
        public static int GetHighestProductOf3(params int[] input)
        {
            if(input.Length < 3)
                throw new Exception("input should have atleast 3 elements.");

            checked
            {
                var highestProductOf3 = input[0] * input[1] * input[2];
                var highestProductOf2 = input[0] * input[1];
                var lowestProductOf2 = input[0] * input[1];
                var highestNumber = Math.Max(input[0], input[1]);
                var lowestNumber = Math.Max(input[0], input[1]);
                for (int i = 2; i < input.Length; i++)
                {
                    var n = input[i];

                    highestProductOf3 = Max(
                        highestProductOf2 * n,
                        lowestProductOf2 * n,
                        highestProductOf3);

                    highestProductOf2 = Max(
                        highestNumber * n,
                        lowestNumber * n,
                        highestProductOf2);

                    lowestProductOf2 = Min(
                        highestNumber * n,
                        lowestNumber * n,
                        lowestProductOf2);

                    highestNumber = Math.Max(highestNumber, n);
                    lowestNumber = Math.Min(lowestNumber, n);
                }

                return highestProductOf3;
            }
        }

        public static int GetHighestProductOfK(int k, params int[] input) 
        {
            if (input.Length <= k)
                throw new Exception("input length should be greater than or equal to k.");

            if (input.Length == 1)
                return input[0];

            int[] highest = new int[k];
            int[] lowest = new int[k];           

            checked
            {
                highest[0] = input[0];
                lowest[0] = input[0];
                for (int i = 1; i < k; i++)
                {
                    highest[i] = highest[i - 1] * input[i];
                    lowest[i] = lowest[i - 1] * input[i];
                }

                for (int i = 1; i < input.Length; i++)
                {
                    for (int j = k - 1; j > 0; j--)
                    {
                        highest[j] = Max(
                            highest[j - 1] * input[i],
                            lowest[j - 1] * input[i],
                            highest[j]);
                        lowest[j] = Min(
                            highest[j - 1] * input[i],
                            lowest[j - 1] * input[i],
                            lowest[j]);
                    }

                    highest[0] = Math.Max(highest[0], input[i]);
                    lowest[0] = Math.Min(lowest[0], input[i]);
                }
            }

            return highest[k - 1];
        }

        private static int Max(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        private static int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }
}
