//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
using System.CodeDom.Compiler;
using System.Globalization;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите количество элементов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Print(" ");
        int[] arr = GenerateRandomArray(n, 100, 1000);
        foreach (int num in arr)
        {
            Print("Элемент : " + num.ToString());
        }
        int count = EvenElements(arr);
        {
            Print("Количество четных элементов : " + count.ToString());
        }
    }

    public static void Print(string res)
    {
        Console.WriteLine(res);
    }

    static int[] GenerateRandomArray(int n, int min_val, int max_val)
    {
        int[] arr = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(min_val, max_val + 1);
        }
        return arr;
    }

    static int EvenElements(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }

        }
        return count;
        {

        }
    }
}