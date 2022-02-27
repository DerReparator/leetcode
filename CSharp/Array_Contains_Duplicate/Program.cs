using System.Collections.Generic;

namespace Array_Contains_Duplicate
{
    public class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> foundNums = new(nums.Length);
            foreach(int number in nums)
            {
                if (foundNums.Contains(number)) return true;
                else foundNums.Add(number);
            }

            return false;
        }
    }
}
