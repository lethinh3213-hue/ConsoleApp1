using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT3
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Nhap ngay :");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang :");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam :");
            int year = int.Parse(Console.ReadLine());
            if (IsValidDate(day, month, year))
            {
                Console.WriteLine("Ngay hop le");
            }
            else
            {
                Console.WriteLine("Ngay khong hop le");
            }

        }
        static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
            {
                return false;
            }
            int[] daysInMonth = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day > daysInMonth[month - 1])
            {
                return false;
            }
            return true;
        }
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

