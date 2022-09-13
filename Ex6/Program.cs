// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введи число ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine($"Число {a} - четное");
        }
        else
        {
            Console.WriteLine($"Число {a} - нечетное");
        }
            
    }
}