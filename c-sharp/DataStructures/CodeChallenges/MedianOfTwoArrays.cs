using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class MedianOfTwoArrays
  {
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

      int spanLength = nums1.Length + nums2.Length;
      int medianCount = spanLength % 2 == 1 ? spanLength / 2 : spanLength / 2 - 1;
      double medianValue;

      int currentOne = 0;
      int currentTwo = 0;

      for (int i = 0; i < medianCount; i++)
      {
        if ((nums1.Length > currentOne) && (nums2.Length > currentTwo))
        {
          if (nums1[currentOne] < nums2[currentTwo])
          {
            currentOne++;
          }
          else
          {
            currentTwo++;
          }
        }
        else if (nums1.Length > currentOne)
        {
          currentOne++;
        }
        else
        {
          currentTwo++;
        }
      }

      if (spanLength % 2 == 0)
      {
        int first;
        int second;
        if ((nums1.Length > currentOne) && (nums2.Length > currentTwo))
        {
          first = nums1[currentOne] < nums2[currentTwo] ? nums1[currentOne] : nums2[currentTwo];
          if (nums1[currentOne] < nums2[currentTwo])
          {
            currentOne++;
          }
          else
          {
            currentTwo++;
          }
        }
        else if (nums1.Length > currentOne)
        {
          first = nums1[currentOne];
          currentOne++;
        }
        else
        {
          first = nums2[currentTwo];
          currentTwo++;
        }

        if ((nums1.Length > currentOne) && (nums2.Length > currentTwo))
        {
          second = nums1[currentOne] < nums2[currentTwo] ? nums1[currentOne] : nums2[currentTwo];
          if (nums1[currentOne] < nums2[currentTwo])
          {
            currentOne++;
          }
          else
          {
            currentTwo++;
          }
        }
        else if (nums1.Length > currentOne)
        {
          second = nums1[currentOne];
        }
        else
        {
          second = nums2[currentTwo];
        }

        medianValue = (double)(first + second) / 2;
      }
      else
      {
        if(nums1.Length == 0)
        {
          medianValue = nums2[currentTwo];
        }
        else if (nums2.Length == 0)
        {
          medianValue = nums1[currentOne];
        }
        else
        {
          if ((nums1.Length > currentOne) && (nums2.Length > currentTwo))
          {
            medianValue = nums1[currentOne] < nums2[currentTwo] ? nums1[currentOne] : nums2[currentTwo];
          }
          else if (nums1.Length > currentOne)
          {
            medianValue = nums1[currentOne];
          }
          else
          {
            medianValue = nums2[currentTwo];
          }
        }
      }
      return medianValue;
    }
  }
}
