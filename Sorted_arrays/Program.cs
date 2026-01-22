using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };

        int[] result = MergeSortedArrays(a, b);

        foreach (int x in result)
            Console.Write(x + " ");
    }

    static T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int i = 0, j = 0, k = 0;
        T[] merged = new T[a.Length + b.Length];

        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) <= 0)
                merged[k++] = a[i++];
            else
                merged[k++] = b[j++];
        }

        while (i < a.Length)
            merged[k++] = a[i++];

        while (j < b.Length)
            merged[k++] = b[j++];

        return merged;
    }
}