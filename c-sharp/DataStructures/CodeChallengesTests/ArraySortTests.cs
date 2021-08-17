using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenges;
using Xunit;

namespace CodeChallengesTests
{
  public class ArraySortTests
  {
    [Fact]
    public void CanSort()
    {
      int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
      ArraySorts.InsertionSort(testArray);
      Assert.Equal(23, testArray[4]);
    }
    [Fact]
    public void CanHandleDups()
    {
      int[] testArray2 = new int[] { 5, 12, 7, 5, 5, 7 };
      ArraySorts.InsertionSort(testArray2);
      Assert.Equal(7, testArray2[4]);
    }
    [Fact]
    public void CanReverse()
    {
      int[] testArray3 = new int[] { 20, 18, 12, 8, 5, -2 };
      ArraySorts.InsertionSort(testArray3);
      Assert.Equal(18, testArray3[4]);
    }
  }
}
