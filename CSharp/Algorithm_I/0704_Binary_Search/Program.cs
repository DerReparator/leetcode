using System;

namespace _0704_Binary_Search
{
    public class Program
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, target, 0, nums.Length);
        }

        private int BinarySearch(int[] nums, int target, int startIdx, int endIdx)
        {
            int middle = startIdx + (endIdx - startIdx) / 2;

            if (nums[middle] == target) return middle;
            if ((endIdx - 1) == startIdx) return -1;

            if (nums[middle] < target) return BinarySearch(nums, target, middle, endIdx);
            if (nums[middle] > target) return BinarySearch(nums, target, startIdx, middle);
            return -1;
        }
    }
}
