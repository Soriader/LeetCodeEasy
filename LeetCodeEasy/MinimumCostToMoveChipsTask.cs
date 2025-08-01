﻿namespace LeetCodeEasy;

public class MinimumCostToMoveChipsTask
{
    public static int MinCostToMoveChips(int[] position)
    {
        int odd = 0;
        int even = 0;

        for (int i = 0; i < position.Length; i++)
        {
            if (position[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        return Math.Min(odd, even);
    }
}
//https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/description/