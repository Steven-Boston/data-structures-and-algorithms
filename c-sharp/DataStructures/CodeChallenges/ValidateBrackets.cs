using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class ValidateBrackets
  {
    public static bool ValidateBracketString(string brackString)
    {
      DataStructures.Stack<char> brackStack = new();
      char[] opens = new char[] { '{', '[', '(' };
      char[] closes = new char[] { '}', ']', ')' };
      foreach(char c in brackString)
      {
        if (opens.Contains(c))
        {
          brackStack.Push(c);
        }
        else if (closes.Contains(c))
        {
          try
          {
            if (BrackMatch(brackStack.Peek(), c))
            {
              brackStack.Pop();
            }
            else
            {
              return false;
            }
          }
          catch
          {
            return false;
          }
        }
      }
      return brackStack.IsEmpty();
    }
    public static bool BrackMatch(char open, char close)
    {
      switch(open)
      {
        case '{':
          return close == '}';
        case '[':
          return close == ']';
        case '(':
          return close == ')';
        default:
          return false;
      }
    }
  }
}
