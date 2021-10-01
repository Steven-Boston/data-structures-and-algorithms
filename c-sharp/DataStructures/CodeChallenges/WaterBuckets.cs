using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class WaterBuckets
  {
    //problem from https://leetcode.com/problems/container-with-most-water/
    public static int MaxArea(int[] height)
    {
      int largestArea = 0;
      int left = 0;
      int right = height.Length - 1;
      int y;
      int x;
      while (left < right)
      {
        x = right - left;
        if (height[left] < height[right])
        {
          y = height[left];
          left++;
        }
        else
        {
          y = height[right];
          right--;

        }
        int area = x * y;
        if (area > largestArea) { largestArea = area; }
      }
      return largestArea;
    }
  }
}
