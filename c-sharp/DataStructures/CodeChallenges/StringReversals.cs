using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class StringReversals
  {
    public static string RevStringWithIterative(string input)
    {
      string result = "";
      for(int i = input.Length-1; i>=0; i--)
      {
        result += input[i];
      }
      return result;
    }
    public static string RevStringWithStack(string input)
    {
      DataStructures.Stack<char> letters = new();
      foreach(char c in input)
      {
        letters.Push(c);
      }
      string result = "";
      while(!letters.IsEmpty())
      {
        result += letters.Pop();
      }
      return result;
    }
    public static string RevStringRecursive(string input)
    {
      if(input.Length == 0)
      {
        return "";
      }
      return RevStringRecursive(input.Substring(1)) + input[0];
    }
  }
}
