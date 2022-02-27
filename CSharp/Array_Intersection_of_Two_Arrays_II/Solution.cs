using System;
using System.Collections.Generic;

namespace Array_Intersection_of_Two_Arrays_II
{
    public class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> shorterInput = nums1.Length < nums2.Length ? new List<int>(nums1) : new List<int>(nums2);
            List<int> longerInput = nums1.Length >= nums2.Length ? new List<int>(nums1) : new List<int>(nums2);

            for (int i = shorterInput.Count - 1; i >= 0;  --i)
            {
                bool found = false;
                
                for (int j = longerInput.Count - 1; j >= 0; --j)
                {
                    if (longerInput[j] == shorterInput[i])
                    {
                        found = true;
                        longerInput.RemoveAt(j);
                        break;
                    }
                }

                if (!found)
                {
                    shorterInput.RemoveAt(i);
                }
            }

            return shorterInput.ToArray();
        }
    }
}
