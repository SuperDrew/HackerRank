using System;
using System.Text;

namespace _31
{
    public static class Utils
    {
        public static string ArrayToString(int[] value)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < value.Length; i++)
            {
                sb.Append(value[i] + " ");
            }
            return sb.ToString();
        }
    }
}
