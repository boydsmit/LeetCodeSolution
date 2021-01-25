﻿using System;

namespace LeetCodeTasks.Mathematical
{
    /*
     * TASK: 877
     *
     * Alex and Lee play a game with piles of stones.  There are an even number of piles arranged in a row, and each
     * pile has a positive integer number of stones piles[i].
     *
     * The objective of the game is to end with the most stones.  The total number of stones is odd, so there are no ties.
     *
     * Alex and Lee take turns, with Alex starting first.  Each turn, a player takes the entire pile of stones from
     * either the beginning or the end of the row.  This continues until there are no more piles left, at which point
     * the person with the most stones wins.
     *
     * Assuming Alex and Lee play optimally, return True if and only if Alex wins the game.
     */
    
    public class StoneGame
    {
        public bool SGame(int[] piles) {
            var collectedA = 0;
            var collectedL = 0;
            
            Array.Sort(piles);

            for (var i = 0; i < piles.Length; i += 2)
            {
                collectedA += piles[i];
                collectedL += piles[i + 1];
            }
            return collectedA < collectedL;
        }
    }
}