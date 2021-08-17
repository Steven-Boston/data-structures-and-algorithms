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
    public void CanInsertSort()
    {
      int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
      ArraySorts.InsertionSort(testArray);
      Assert.Equal(23, testArray[4]);
    }
    [Fact]
    public void CanInsertHandleDups()
    {
      int[] testArray2 = new int[] { 5, 12, 7, 5, 5, 7 };
      ArraySorts.InsertionSort(testArray2);
      Assert.Equal(7, testArray2[4]);
    }
    [Fact]
    public void CanInsertReverse()
    {
      int[] testArray3 = new int[] { 20, 18, 12, 8, 5, -2 };
      ArraySorts.InsertionSort(testArray3);
      Assert.Equal(18, testArray3[4]);
    }
    [Fact]
    public void CanMergeSort()
    {
      int[] testArr = new int[] { 25, 7, 8, 4, 10, 78, 66 };
      ArraySorts.MergeSort(testArr);
      Assert.Equal(66, testArr[5]);
    }
    [Fact]
    public void CanMergeDups()
    {
      int[] testArr = new int[] { 7, 7, 8, 4, 10, 7, 66 };
      ArraySorts.MergeSort(testArr);
      Assert.Equal(8, testArr[4]);
    }
    [Fact]
    public void CanMergeReverse()
    {
      int[] testArray = new int[] { 20, 18, 12, 8, 5, -2 };
      ArraySorts.MergeSort(testArray);
      Assert.Equal(18, testArray[4]);
    }
  }
}
