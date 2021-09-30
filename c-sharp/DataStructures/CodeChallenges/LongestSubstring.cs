using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeChallenges
{
  class LongestSubstring
  {
    public static int LengthOfLongestSubstring(string s)
    {
      int longest = 1;
      Dictionary<char, int> subCounts = new();
      for (int i = 0; i < s.Length; i++)
      {
        if(subCounts.ContainsKey(s[i]))
        {
          if(i - subCounts[s[i]] > longest)
          {
            longest = i - subCounts[s[i]];
          }
          subCounts[s[i]] = i;
        }
        else
        {
          subCounts.Add(s[i], i);
        }
      }
      return longest;
    }
  }
}
