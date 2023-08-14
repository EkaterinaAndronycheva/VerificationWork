/*Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;

namespace task
{
    class Program
    {
        static void PrintArray(string[] x)
        {
            Console.Write("[");
            for(int i = 0; i < x.Length - 1; i++)
            {
                Console.Write($"{x[i]}, ");
            }
            string t = x[x.Length-1];
            Console.Write($"{t}]");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] mas = new string[n];
            string[] newmas = new string[n];
            int m = 0; //количество элементов, длина которых меньше, либо равна трем

            //чтение массива с клавиатуры и запоминание строк, которые удовлетворяют условию
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i+1} элемент: ");
                mas[i] = Console.ReadLine();
                if (mas[i].Length <= 3)
                {
                    newmas[m] = mas[i];
                    m++;
                }
            }
            
            //массив-результат только с нужными элементами без пустых значений
            string[] res = new string[m];
            int k = 0;
            while (m != 0)
            {
                res[k] = newmas[k];
                k++;
                m--;
            }

            //вывод результата на экран
            if (m == 0) Console.WriteLine("[]");
            else PrintArray(res);
        }
    }
}
