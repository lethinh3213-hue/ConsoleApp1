using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int TongSoNguyenToNhoHonN = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i)) TongSoNguyenToNhoHonN += i;
            }
            Console.WriteLine("Tong so nguyen to nho hon n: " + TongSoNguyenToNhoHonN);
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
    }
}