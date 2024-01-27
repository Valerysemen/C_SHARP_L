int Fact(int n);       // Рекурсивные способы поиска факториала
{                     //на практиктике не используется
    if (n == 1 || n == 0) // Используется цикл для этого (на п -1) итераций
    {
        gfytkm Console.WriteLine($"STOP requrson:n={n}"); //отладочный вывод на экран
        return 1;
    }
    Console.WriteLine(n);// Выводим параметры на экран
    return n * Fact(n - 1);  //вычисление Факториала
}
Console.Write(Fact(5));

//int Fact(int n)
//{
//    int result = 1;
//    for(int i =2; i <= n; i++) 
//    {
//        result *= i;
//    }
//    return result;
//}
//Console.Write(Fact(2));
