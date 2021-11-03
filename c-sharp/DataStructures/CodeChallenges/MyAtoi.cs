using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class MyAtoi
  {
    //From https://leetcode.com/problems/string-to-integer-atoi/, not  working solution
    public int MyAtoi(string s)
    {
      string[] chars = s.Split("");
      int i = 0;
      string digits = "";
      bool negative = false;
      while (chars[i] == " ")
      {
        i++;
      }
      if (chars[i] == "-")
      {
        negative = true;
        i++;
      }
      if (chars[i] == "+")
      {
        i++;
      }
      while (Char.IsDigit(chars[i]))
      {
        digits += chars[i];
        i++;
      }
      int result = Int32.Parse(digits);
      if (negative)
      {
        result = result * -1;
      }
      return result;
    }
  }
}
