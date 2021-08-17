using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class ArraySorts
  {
    public static void InsertionSort(int[] array)
    {
      Console.WriteLine("Initial Array:");
      foreach (int num in array)
      {
        Console.Write($"{num}, ");
      };
      Console.WriteLine("");
      for (int i = 1; i<array.Length; i++)
      {
        int j = i - 1;
        int temp = array[i];

        while(( j >= 0 ) && ( temp < array[j] ))
        {
          array[j + 1] = array[j];
          j = j - 1;
        }

        array[j + 1] = temp;

        Console.WriteLine($"After {i}:");
        foreach (int num in array)
        {
          Console.Write($"{num}, ");
        }
        Console.WriteLine("");
      }
      Console.WriteLine("Final Sort:");
      foreach (int num in array)
      {
        Console.Write($"{num}, ");
      };
      Console.WriteLine("");
    }
  }
}
