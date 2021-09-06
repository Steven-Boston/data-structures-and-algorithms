using System;
using DataStructures;
namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      HashTable testTable = new(800);
      testTable.Add("red", "frog");
      testTable.Add("redfin", "frogzilla");
      testTable.Summary();
    }
  }
}
