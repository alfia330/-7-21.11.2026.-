//упражнение 8.2
using System;

class Program
{
    static string Reverse(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        Console.WriteLine("Результат: " + Reverse(input));

        Console.WriteLine(Reverse("привет") == "тевирп");
        Console.WriteLine(Reverse("abc") == "cba");
        Console.WriteLine(Reverse("") == "");
    }
}

