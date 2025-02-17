using System;
using System.Diagnostics;
namespace Assignment_18_Algorithms
{
    internal class SortingEfficiency
    {
        static void Main(string[] args)
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            Random random = new Random();
            foreach (int size in datasetSizes)
            {
                long mergeTime;
                long bubbleTime;
                long quickTime;
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next(1, size * 10);
                }
                //Bubble Sort
                Stopwatch stopwatch = Stopwatch.StartNew();
                BubbleSort(data);
                stopwatch.Stop();
                bubbleTime = stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Bubble Sort in {size} elements: {bubbleTime} ms");
                //Merge Sort
                stopwatch.Restart();
                MergeSort(data, 0, size - 1);
                stopwatch.Stop();
                mergeTime = stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Merge Sort in {size} elements: {mergeTime} ms");
                //Quick Sort
                stopwatch.Restart();
                QuickSort(data, 0, size - 1);
                stopwatch.Stop();
                quickTime = stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Quick Sort in {size} elements: {quickTime} ms");
                Console.WriteLine();
                if (bubbleTime > quickTime && bubbleTime > mergeTime)
                {
                    Console.WriteLine("Bubble Sort is impractical for large datasets. Merge Sort & Quick Sort perform well.");
                }
            }
        }
        static void BubbleSort(int[] arr)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];
            int i, j;
            for (i = 0; i < leftSize; i++)
            {
                leftArray[i] = arr[i + left];
            }
            for (j = 0; j < rightSize; j++)
            {
                rightArray[j] = arr[mid + j + 1];
            }
            i = 0;
            j = 0;
            int k = left;
            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k++] = leftArray[i++];
                }
                else
                {
                    arr[k++] = rightArray[j++];
                }
            }
            while (i < leftSize)
            {
                arr[k++] = leftArray[i++];
            }
            while (j < rightSize)
            {
                arr[k++] = rightArray[j++];
            }
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int t = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = t;
            return i + 1;
        }
    }
}
