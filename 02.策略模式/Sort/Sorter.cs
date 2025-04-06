using System;
using System.Collections.Generic;

namespace _02.策略模式.Sort;

public class Sorter<T>
{
    public void Sort(T[] arr, IComparer<T> comparer)
    {
        if (arr == null || arr.Length <= 1)
        {
            return;
        }

        if (comparer == null)
        {
            throw new ArgumentNullException(nameof(comparer), "comparer can not be null!");
        }

        for (int i = 0; i < arr.Length; i++)
        {
            int minPos = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                minPos = comparer.Compare(arr[j], arr[minPos]) < 0 ? j : minPos;
            }
            Swap(arr, i, minPos);
        }
    }

    public void Swap(T[] arr, int i, int j)
    {
        T temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
