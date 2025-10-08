using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int TongLe = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0) TongLe += i;
            }
            Console.WriteLine("Tong cac so le trong mang la: " + TongLe);

            int TongSoNguyenTo = 0;
            foreach (int i in arr)
            {
                if (IsPrime(i)) TongSoNguyenTo += i;
            }
            
            
            Console.WriteLine("Tong cac so nguyen to trong mang la: " + TongSoNguyenTo);

            int SoChinhPhuongNhoNhat = int.MaxValue;
            foreach (int i in arr)
            {
                if (IsSquare(i))
                {
                    if (i < SoChinhPhuongNhoNhat) SoChinhPhuongNhoNhat = i;
                }
            }
            if (SoChinhPhuongNhoNhat == int.MaxValue) Console.WriteLine("-1");
            else Console.WriteLine("So chinh phuong nho nhat la: " + SoChinhPhuongNhoNhat);

        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static bool IsSquare(int n)
        {
            if (n < 0) return false;
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
    }
}


