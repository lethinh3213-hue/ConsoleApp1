using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT5
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
            if (!IsValidDate(day, month, year))
            {
                Console.WriteLine("Ngay khong hop le");
                return;
            }
            
            Console.WriteLine("Thu trong tuan la: " + DayOfWeek(day, month, year));

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
        static string DayOfWeek(int day, int month, int year)
        {
            if (month < 3)
            {
                month += 12;
                year--;
            }
            int k = year % 100;
            int j = year / 100;
            int f = day + (13 * (month + 1)) / 5 + k + (k / 4) + (j / 4) + (5 * j);
            int dayOfWeek = f % 7;
            string[] days = { "Thu 7", "Chu Nhat", "Thu 2", "Thu 3", "Thu 4", "Thu 5", "Thu 6" };
            return days[dayOfWeek];
        }
    }
}

