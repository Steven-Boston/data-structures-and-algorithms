using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class RepeatedWords
  {
    public static string RepeatedWord(string input)
    {
      HashTable table = new(1024);
      string[] wordArray = input.Split(' ');
      foreach (string rawWord in wordArray)
      {
        string word = rawWord.ToLower();
        if (table.Contains(word))
        {
          return word;
        }
        else
        {
          table.Add(word, word);
        }
      }
      return "No Repeated Words";
    }
  }
}
