﻿using System.Collections.Generic;

namespace _31.Zero_Game
{
    public static class Play
    {
        private const string Alice = "Alice";
        private const string Bob = "Bob";

        public static string Go(int[] values)
        {
            var sequence = new List<int>(values);
            var player = Alice;
            bool canRemoveElement = false;
            do
            {
                canRemoveElement = false;
                // Find element that can be removed
                int indexToRemove = 0;
                for (int i = 0; i < sequence.Count - 2; i++)
                {
                    var leftSideValue = sequence[i];
                    var rightSideValue = sequence[i + 2];
                    if (leftSideValue == 0 && rightSideValue == 0)
                    {
                        indexToRemove = i + 1;
                        canRemoveElement = true;
                        // Remove index
                        sequence.RemoveAt(indexToRemove);
                        // Swop player
                        player = PickOtherPlayer(player);
                        break;
                    }
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
