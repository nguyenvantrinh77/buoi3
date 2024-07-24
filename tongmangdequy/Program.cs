using System;

class Program
{
    static void Main()
    {
        // Nhập số nguyên n từ bàn phím
        Console.Write("Nhap gia tri n: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong: ");
        }

        // Tính tổng mảng từ 1 đến n
        int sum = SumArrayRecursive(n);

        // Hiển thị kết quả
        Console.WriteLine($"Tong mang tu 1 den {n} : {sum}");
    }

    static int SumArrayRecursive(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else
        {
            return n + SumArrayRecursive(n - 1);
        }
    }
}
