// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 65, 1, 17, -22, 21, 99 };
        int temp;
        Console.Write("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        Console.Write("\n Перевернутый  массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}