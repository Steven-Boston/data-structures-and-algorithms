using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class Solution
  {
    public int Jump(int[] nums)
    {
      return Jumps(nums, 0, 0);
    }
    //Not working!
    public int Jumps(int[] nums, int index, int jumpCount)
    {
      if (index + nums[index] >= nums.Length - 1)
      {
        return jumpCount + 1;
      }
      jumpCount++;
      int leastJumps = 0;
      for (int i = index; i < index + nums[index]; i++)
      {
        int thisJumps = Jumps(nums, (index + i), jumpCount);
        if (leastJumps == 0 || leastJumps > thisJumps)
        {
          leastJumps = thisJumps;
        }
      }
      return leastJumps;
    }
  }
}
