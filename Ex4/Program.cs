//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Program
{
    private static void Main(string[] args)
    {
        // Вводим и преобразовываем переменные (три числа)
        Console.Write("Введи число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введи число b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введи число c: ");
        int c = int.Parse(Console.ReadLine());

        // Вводим дополнительную переменную
        int max = 0;

        // Производим сравнения
        if (a > b);
        if (a > c) ;
        max = a;

        if (b > a) ;
        if (b > c) ;
        max = b;

        if (c > a) ;
        if (c > b) ;
        max = c;

        // Выводим результат
        Console.WriteLine($"Наибольшее число из трех чисел равно числу:  {max}");
    }
}