using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class SearchInsertIndex
  {
    //https://leetcode.com/problems/search-insert-position/
    public int SearchInsert(int[] nums, int target)
    {
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] >= target)
        {
          return i;
        }
        else if (i + 1 == nums.Length)
        {
          return i + 1;
        }
      }
      return nums.Length;
    }
  }
}
