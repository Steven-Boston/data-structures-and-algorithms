using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class HashTable
  {
    public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
    public HashTable(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    public int Hash(string key)
    {
      int hashValue = 0;
      
      foreach(char letter in key)
      {
        hashValue += letter;
      }

      return hashValue * 599 % Map.Length;
    }

    public void Add(string key, string value)
    {
      int hashKey = Hash(key);

      if(Map[hashKey] == null)
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
      Map[hashKey].AppendLinked(entry);
    }

    public bool Contains(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey!] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key)
          {
            return true;
          }
          current = current.Next;
        }
      }
      return false;
    }

    public string Get(string key)
    {
      int hashKey = Hash(key);
      if (Map[hashKey!] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key)
          {
            string got = current.Value.Value;
            return got;
          }
          current = current.Next;
        }
      }
      string missingItem = $"{key} was not in the table";
      return missingItem;
    }

    public void Summary()
    {
      for(int i=0; i<Map.Length; i++)
      {
        Console.WriteLine($"Index {i}:");
        if(Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while(current != null)
          {
            Console.WriteLine($"Key: {current.Value.Key}, Value: {current.Value.Value}");
            current = current.Next;
          }
        }
      }
    }
  }
}
