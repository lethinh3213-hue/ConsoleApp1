using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            Console.WriteLine("Ma tran vua tao:");
            Xuat(matrix, n, m);

            Console.WriteLine("Phan tu lon nhat trong ma tran: " + MaxElement(matrix, n, m));
            Console.WriteLine("Phan tu nho nhat trong ma tran: " + MinElement(matrix, n, m));
            Console.WriteLine("Dong co tong lon nhat: " + RowWithMaxSum(matrix, n, m));
            Console.WriteLine("Tong cac so khong phai so nguyen to trong ma tran: " + SumOfNonPrime(matrix, n, m));

            Console.WriteLine("Nhap dong k can xoa: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ma tran sau khi xoa dong thu {k}:");
            RemoveRow(matrix, n, m, k);
            Xuat(matrix, n - 1, m);

            Console.WriteLine("Ma tran sau khi xoa cot chua phan tu lon nhat:");
            RemoveColumnWithMaxElement(matrix, ref n, ref m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Xuat(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int MaxElement(int[,] matrix, int n, int m)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }
            return max;
        }
        static int MinElement(int[,] matrix, int n, int m)
        {
            int min = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
            }
            return min;
        }
        static int RowWithMaxSum(int[,] matrix, int n, int m)
        {
            int maxSum = int.MinValue;
            int rowIndex = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    rowIndex = i;
                }
            }
            return rowIndex;
        }
        static int SumOfNonPrime(int[,] matrix, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!IsPrime(matrix[i, j])) sum += matrix[i, j];
                }
            }
            return sum;
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void RemoveRow(int[,] matrix, int n, int m, int k)
        {
            if (k < 0 || k >= n)
            {
                Console.WriteLine("Dong k khong hop le");
                return;
            }
            for (int i = k; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = matrix[i + 1, j];
                }
            }
        }
        static void RemoveColumnWithMaxElement(int[,] matrix, ref int n, ref int m)
        {
            int max = MaxElement(matrix, n, m);
            int colIndex = -1;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] == max)
                    {
                        colIndex = j;
                        break;
                    }
                }
                if (colIndex != -1) break;
            }
            if (colIndex == -1) return;
            for (int i = 0; i < n; i++)
            {
                for (int j = colIndex; j < m - 1; j++)
                {
                    matrix[i, j] = matrix[i, j + 1];
                }
            }
            m--;
        }
    }
}