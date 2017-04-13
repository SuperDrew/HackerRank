namespace _31.Accurate_Sorting
{
    using System;

    public static class Sort
    {
        private const string No = "No";

        private const string Yes = "Yes";

        /// <summary>
        /// Tests if value is sortable accurately, not value's values must be distinct
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DoIt(int[] value)
        {
            ConsoleWriteArray("input: ", value);

            // Write Your Code Here
            bool didAtLeastOneSwap;
            do
            {
                didAtLeastOneSwap = false;
                for (var i = 0; i < value.Length - 1; i++)
                {
                    // If abs of difference is equal to one then we can see if we want to swop
                    var currentValue = value[i];
                    var nextValue = value[i + 1];
                    if (Math.Abs(currentValue - nextValue) == 1)
                    {
                        // If current position value is greater than next, swop values
                        if (currentValue > nextValue)
                        {
                            var temp = currentValue;
                            value[i] = nextValue;
                            value[i + 1] = temp;
                            didAtLeastOneSwap = true;
                        }
                    }
                }
            }
            while (didAtLeastOneSwap);

            // Check if value is sorted
            var isSorted = true;
            for (var i = 0; i < value.Length - 1; i++)
            {
                if (value[i] > value[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            ConsoleWriteArray("output: ", value);
            return isSorted ? Yes : No;
        }

        private static void ConsoleWriteArray(string preamble, int[] value)
        {
            Console.Write(preamble);
            for (var i = 0; i < value.Length; i++)
            {
                Console.Write(value[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
