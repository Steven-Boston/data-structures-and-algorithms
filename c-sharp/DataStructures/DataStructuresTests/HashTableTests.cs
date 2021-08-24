using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using DataStructures;
namespace DataStructuresTests
{
  public class HashTableTests
  {
    [Fact]
    public void CanHash()
    {
      HashTable testTable = new(800);
      Assert.Equal(530, testTable.Hash("walrus"));
    }
    [Fact]
    public void CanAddAndGetValue()
    {
      HashTable testTable = new(800);
      testTable.Add("red", "frog");
      testTable.Add("redfin", "frogzilla");
      testTable.Add("redfinch", "walrus");
      Assert.Equal("redfin: frogzilla", testTable.Get("redfin"));
    }
    [Fact]
    public void CanHandleNull()
    {
      HashTable testTable = new(800);
      Assert.Equal("thing was not in the table", testTable.Get("thing"));
    }
    [Fact]
    public void CanHandleCollisions()
    {
      HashTable testTable = new(800);
      testTable.Add("result", "one");
      testTable.Add("luster", "two");
      Assert.Equal("two", testTable.Map[testTable.Hash("result")].Head.Next.Value.Value);
    }
  }
}
