using System.Collections.Generic;

namespace _31.Zero_Game
{
    public static class Play
    {
        private const string Alice = "Alice";
        private const string Bob = "Bob";

        public static string Go(int[] sequence)
        {
            var player = Alice;
            bool canRemoveElement = false;
            do
            {
                canRemoveElement = false;
                // Find element that can be removed
                int indexToRemove = 0;
                for (int i = 0; i < sequence.Length - 2; i++)
                {
                    var leftSideValue = sequence[i];
                    var rightSideValue = sequence[i + 2];
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
                    var list = new List<int>(sequence);
                    list.RemoveAt(indexToRemove);
                    sequence = list.ToArray();
                }

                // Swop player
                if (canRemoveElement)
                {
                    player = PickOtherPlayer(player);
                }
            } while (canRemoveElement);

            string winner = PickOtherPlayer(player);
            return winner;
        }

        private static string PickOtherPlayer(string player)
        {
            return player == Alice ? Bob : Alice;
        }
    }
}
