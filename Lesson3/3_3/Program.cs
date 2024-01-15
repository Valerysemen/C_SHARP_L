void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_arr[i] = arr[i] * arr[size - i - 1];

    if (size % 2 == 1)
        new_arr[flex_size - 1] = arr[size / 2];
    return new_arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int[] arr_new = PairsNum(mass);
Print(arr_new);

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

using System;

namespace My_3_3
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Количество элементов массива: ");
            int Count = int.Parse(System.Console.ReadLine()!);
            int[] My_massive = new int[Count];

            Random El_mas = new();
            System.Console.Write("Массив: [ ");
            for (int i = 0; i < Count; i++)
            {
                My_massive[i] = El_mas.Next(-10, 10);
                System.Console.Write(My_massive[i] + " ");
            }
            System.Console.WriteLine("]");

            int b = 0;
            Count = Count - 1;
            while ((b != Count) && (b < Count))
            {
                // Исправить!! Нужно вывести в НОВЫЙ массив.

                My_massive[b] = My_massive[b] + My_massive[Count];
                System.Console.Write(My_massive[b] + " ");
                b++;
                Count--;
                if ((b != 0) && (b == Count))
                    System.Console.WriteLine($"(Элемент {My_massive[b]} с индексом {b} не имеет пары)");
            }
        }
    }
}