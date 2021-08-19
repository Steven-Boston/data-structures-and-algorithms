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
    public static void MergeSort(int[] array)
    {
      if(array.Length>1)
      {
        double n = array.Length / 2;
        int mid = (int)Math.Ceiling(n);
        int[] left = new int[mid];
        int j = 0;
        int[] right = new int[array.Length - mid];
        int k = 0;

        for(int i = 0; i<array.Length; i++)
        {
          if(i<mid)
          {
            left[j] = array[i];
            j++;
          }
          else
          {
            right[k] = array[i];
            k++;
          }
        }
        MergeSort(left);
        MergeSort(right);
        Merge(left, right, array);
      }
    }

    public static void Merge(int[] left, int[] right, int[] array)
    {
      int i = 0;
      int j = 0;
      int k = 0;

      while((i<left.Length)&&(j<right.Length))
      {
        if(left[i]<right[j])
        {
          array[k] = left[i];
          i++;
        }
        else
        {
          array[k] = right[j];
          j++;
        }
        k++;
      }
      if(i==left.Length)
      {
        while(j<right.Length)
        {
          array[k] = right[j];
          k++;
          j++;
        }
      }
      else
      {
        while (i < left.Length)
        {
          array[k] = left[i];
          k++;
          i++;
        }
      }
    }

    public static void QuickSort(int[] arr, int left, int right)
    {
      Console.WriteLine("QuickSort Call:");
        Console.WriteLine($"  Left: {left}");
        Console.WriteLine($"  Right: {right}");
        Console.Write("  Array Status:");
        foreach (int num in arr)
        {
          Console.Write($" {num},");
        }
        Console.WriteLine("\n");
      if (left<right)
      {
        int position = Partition(arr, left, right);
        Console.WriteLine($"Position: {position}");
        QuickSort(arr, left, position - 1);
          QuickSort(arr, position + 1, right);
        }
    }

    public static int Partition(int[] arr, int left, int right)
    {
      Console.WriteLine($"Partition, Left = {left}, Right = {right}");
      int pivot = arr[right];
      int low = left - 1;

      for(int i=left; i<right; i++)
      {
        Console.WriteLine($"  i: {i}");
        Console.WriteLine($"  pivot: {pivot}");
        Console.Write("  Array Status:");
        foreach (int num in arr)
        {
          Console.Write($" {num},");
        }
        Console.WriteLine();
        if (arr[i] <= pivot)
        {
          low++;
          Swap(arr, i, low);
        }
        Console.Write("  After Check/Swap:");
        foreach (int num in arr)
        {
          Console.Write($" {num},");
        }
        Console.WriteLine("\n");
      }
      Swap(arr, right, low + 1);

      return low + 1;
    }

    public static void Swap(int[] arr, int i, int low)
    {
      int temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
    }
  }
}
