using System;
using System.Diagnostics;
using System.Linq;

class SortComparison
{
    static void Main()
    {
        int n = 10_000;
        Random rand = new Random();
        int[] data = Enumerable.Range(0, n).Select(_ => rand.Next(n)).ToArray();

        TestSort("Bubble Sort", data, BubbleSort);
        TestSort("Merge Sort", data, MergeSort);
        TestSort("Quick Sort", data, QuickSort);
    }

    static void TestSort(string name, int[] original, Action<int[]> sortMethod)
    {
        int[] copy = (int[])original.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        sortMethod(copy);
        sw.Stop();
        Console.WriteLine($"{name} Time: {sw.ElapsedMilliseconds} ms");
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;
        int mid = arr.Length / 2;
        int[] left = arr.Take(mid).ToArray();
        int[] right = arr.Skip(mid).ToArray();

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
            arr[k++] = (left[i] < right[j]) ? left[i++] : right[j++];
        while (i < left.Length) arr[k++] = left[i++];
        while (j < right.Length) arr[k++] = right[j++];
    }

    static void QuickSort(int[] arr)
    {
        QuickSortHelper(arr, 0, arr.Length - 1);
    }

    static void QuickSortHelper(int[] arr, int low, int high)
    {
        if (low >= high) return;
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        int pi = i + 1;

        QuickSortHelper(arr, low, pi - 1);
        QuickSortHelper(arr, pi + 1, high);
    }
}
