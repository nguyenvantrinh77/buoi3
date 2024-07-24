using System;

namespace TimKiemNhiPhan
{
    internal class TimKiemNhiPhan
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n, x;

            // Input the number of elements in the array
            do
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            // Input the elements of the array
            nhapMang(a, n);

            // Display the unsorted array
            Console.WriteLine("Mang ban dau:");
            xuatMang(a, n);

            // Sort the array
            Array.Sort(a, 0, n);

            // Display the sorted array
            Console.WriteLine("Mang sau khi sap xep:");
            xuatMang(a, n);

            // Input the element to search
            Console.Write("\nNhap gia tri can tim: ");
            x = int.Parse(Console.ReadLine());

            // Perform binary search
            int kq = binarySearch(a, 0, n - 1, x);

            // Display the result
            if (kq == -1)
                Console.WriteLine($"Khong tim thay {x} trong mang");
            else
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq + 1} (chi so 0)");
        }

        static void nhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        static int binarySearch(int[] a, int left, int right, int key)
        {
            if (left <= right)
            {
                int mid = (left + right) / 2;

                if (a[mid] == key)
                    return mid;

                if (key < a[mid])
                    return binarySearch(a, left, mid - 1, key);
                else
                    return binarySearch(a, mid + 1, right, key);
            }

            return -1;
        }
    }
}
