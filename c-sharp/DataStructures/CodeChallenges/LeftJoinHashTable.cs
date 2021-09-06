using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class LeftJoinHashTable
  {
    public static List<string[]> LeftJoin(HashTable left, HashTable right)
    {
      List<string[]> joined = new();
      for (int i = 0; i < left.Map.Length; i++)
      {
        if (left.Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = left.Map[i].Head;
          while (current != null)
          {
            string[] newArray = new string[3];
            newArray[0] = current.Value.Key;
            newArray[1] = current.Value.Value;
            if (right.Contains(current.Value.Key))
            {
              newArray[2] = right.Get(current.Value.Key);
            }
            joined.Add(newArray);
            current = current.Next;
          }
        }
      }
      return joined;
    }
  }
}
