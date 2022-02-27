using System;

namespace Array_Single_Number
{
    public class Program
    {
        public static int SingleNumber(int[] nums)
        {
            int runningXor = 0;
            foreach(int num in nums)
            {
                runningXor ^= num;
            }

            return runningXor;
        }
    }
}
