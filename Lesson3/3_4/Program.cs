//Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на
// нулевом индексе массива, а старший – на 2-м.

using System;

namespace My_3_1
{
    class Program
    {
        static void Main()
        {

            Console.Write("Введите натуральное трёхзначное число: ");
            int element = Convert.ToInt32(Console.ReadLine()!);

            int[] My_mass = new int[3];
            int set = 0;
            if ((element > 99) && (element < 1000))
            {
                System.Console.Write("[ ");
                while (element > 0)
                {
                    My_mass[set] = element % 10;
                    element = element / 10;
                    Console.Write(My_mass[set] + " ");
                    set++;
                }
                System.Console.Write("]");
                System.Console.WriteLine();
            }
            else
                Console.WriteLine("Неверные данные");
        }
    }
}