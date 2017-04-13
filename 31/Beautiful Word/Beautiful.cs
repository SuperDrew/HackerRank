namespace _31.Beautiful_Word
{
    using System.Collections.Generic;

    public static class Beautiful
    {
        private static readonly List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };

        private const string Yes = "Yes";

        private const string No = "No";

        public static string IsBeautiful(string value)
        {
            // Check for duplicates
            for (var i = 0; i < value.Length-1; i++)
            {
                var a = value[i];
                var b = value[i + 1];
                if (a.Equals(b))
                {
                    return No;
                }
            }

            // Check for vowel duplicates
            for (var i = 0; i < value.Length - 1; i++)
            {
                var a = value[i];
                var b = value[i + 1];
                if (!Vowels.Contains(a))
                {
                    continue;
                }

                if (Vowels.Contains(b))
                {
                    return No;
                }

                // If a and b aren't vowels can move iteration ahead of both of them.
                i++;
            }

            return Yes;
        }
    }
}
