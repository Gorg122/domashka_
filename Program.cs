using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {int size, a1 = 0, b2 = 0;
			Console.WriteLine("Введите количество эелементов в массиве:");
			size = int.Parse(Console.ReadLine());
			int[] a = new int[Math.Abs(size)];
			string aa;
			for (int i = 0; i < Math.Abs(size); i++)
			{
				Console.Write("Введите элемент номер {0} :", i + 1);
				aa = Console.ReadLine();
				a[i] = Convert.ToInt16(aa);
				int res = ((a[i] % 2 == 0) ? b2++ : a1++);
			}
			int[] massiv1 = new int[a1];
			int[] massiv2 = new int[b2];
			for (int i = 0, k = 0, k2 = 0; i < size; i++)
			{
				if (a[i] % 2 == 0)
				{
					massiv2[k] = a[i];
					k++;
				}
				else {
					massiv1[k2] = a[i];
					k2++;
				}
			}
			foreach (int j in a)
			{
				Console.Write("{0} ", j);
			}
			Console.WriteLine("\r\nЧетные:");
			foreach (int j in massiv2)
			{
				Console.Write("{0} ", j);
			}
			Console.WriteLine("\r\nНечетные:");
			foreach (int j in massiv1)
			{
				Console.Write("{0} ", j);
			}
		}
        }
    }

