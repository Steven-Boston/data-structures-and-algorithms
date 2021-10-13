using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class ZigZagString
  {
    //https://leetcode.com/problems/zigzag-conversion/
    public static string ZigZagConvert(string s, int numRows)
    {
      if(numRows == 1) { return s; }
      List<List<char>> bucket = new();
      for(int i = 0; i < numRows; i++)
      {
        bucket.Add(new());
      }
      int point = 0;
      int delta = 1;
      foreach(char letter in s)
      {
        bucket[point].Add(letter);
        if(point+delta < numRows && point+delta >= 0)
        {
          point += delta;
        }
        else
        {
          delta = delta * -1;
          point += delta;
        }
      }
      string result = "";
      for(int i = 0; i<numRows; i++)
      {
        foreach(char letter in bucket[i])
        {
          result += letter;
        }
      }
      return result;
    }
  }
}
