using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT4
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Nhap thang :");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam :");
            int year = int.Parse(Console.ReadLine());
            int[] DaysInMonth = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day = DaysInMonth[month];
            Console.WriteLine("So ngay trong thang :" + day);
        }
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

