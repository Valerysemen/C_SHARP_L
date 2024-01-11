﻿int n = 10;
int[] array = { 2, 95, 4, 7, 8, 35, 1, 3, 8, 6 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);
