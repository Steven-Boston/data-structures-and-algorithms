using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class JumpGame
  {
    public static bool CanJump(int[] nums)
    {
      int target = nums.Length - 1;
      while (target != 0)
      {
        int dest = target;
        for (int i = 0; i < dest; i++)
        {
          if((target - i) <= nums[i])
          {
            target = i;
            i += dest;
          }
        }
        if(dest == target)
        {
          return false;
        }
      }
      return true;
    }
  }
}
