using System.Collections.Generic;

namespace _31.Zero_Game
{
    public static class Play
    {
        public static string Go(int[] values)
        {
            var Alice = "Alice";
            var Bob = "Bob";

            var player = Alice;
            bool canRemoveElement = false;
            do
            {
                canRemoveElement = false;
                // Find element that can be removed
                int indexToRemove = 0;
                for (int i = 0; i < values.Length - 2; i++)
                {
                    var leftSideValue = values[i];
                    var rightSideValue = values[i + 2];
                    if (leftSideValue == 0 && rightSideValue == 0)
                    {
                        indexToRemove = i + 1;
                        canRemoveElement = true;
                        break;
                    }
                }

                // Remove index
                if (canRemoveElement)
                {
                    var list = new List<int>(values);
                    list.RemoveAt(indexToRemove);
                    values = list.ToArray();
                }

                // Swop player
                if (canRemoveElement)
                {
                    player = player == Alice ? Bob : Alice;
                }
            } while (canRemoveElement);

            string winner = player == Alice ? Bob : Alice;
            return winner;
        }
    }
}
