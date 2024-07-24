using System;

namespace QuickSortDeQuy
{
    internal class Program
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            // Input the number of elements in the array
            do
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            // Input the elements of the array
            NhapMang(a, n);

            // Display the unsorted array
            Console.WriteLine("Mang ban dau:");
            XuatMang(a, n);

            // Perform QuickSort
            QuickSort(a, 0, n - 1);

            // Display the sorted array
            Console.WriteLine("Mang sau khi sep xep:");
            XuatMang(a, n);
        }

        static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
