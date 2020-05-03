using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    class MedianTwoSortedArraySolution
    {
        public void execute()
        {
            var nums1 = new int[] { 1, 3};
            var nums2 = new int[] { 2};
            var data = FindMedianSortedArrays(nums1, nums2);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int sum = nums1.Length + nums2.Length;
            int pos = (sum/2) % 2 == 0 ? sum / 2 : (sum / 2) + 1;
            int x = 0;
            int i = 0;
            int j = 0;
            int temp = 0;
            while (x < pos)
            {
                if(i<len1 && j < len2)
                {
                    if (nums1[i] < nums2[j])
                    {
                        temp = nums1[i];
                        i++;
                        x++;
                    }
                    else if (nums2[j] < nums1[i])
                    {
                        temp = nums2[j];
                        j++;
                        x++;
                    }
                }
                else if(i<len1)
                {
                    temp = nums1[i];
                    i++;
                    x++;
                }
                else
                {
                    temp = nums1[j];
                    j++;
                    x++;
                }
            }

            if(sum % 2 != 0)
            {
                return temp;
            }
            else
            {
                if (i < len1 && j < len2)
                {
                    return ((nums1[i] < nums2[j] ? nums1[i] : nums2[j])+ temp)/2;
                }
                else if (i < len1)
                    return (double)(nums1[i]+ temp)/2;
                else
                    return (double)(nums2[j]+ temp)/2;
            }
        }
    }
}
