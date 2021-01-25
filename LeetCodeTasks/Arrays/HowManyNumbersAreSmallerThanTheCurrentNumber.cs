﻿namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1365
     *
     * Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is,
     * for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
     *
     * Return the answer in an array.
     */
    
    public class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums) {
            var output = new int[nums.Length];
        
            for (var i = 0; i < nums.Length; i++)
            {
                foreach (var num in nums)
                {
                    if (nums[i] - num > 0)
                    {
                        output[i]++;
                    }
                }
            }
            return output;
        }
    }
}