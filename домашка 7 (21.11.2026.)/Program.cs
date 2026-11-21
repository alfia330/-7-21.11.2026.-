//упражнение 8.3
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("Файл не существует!");
            return;
        }

        string content = File.ReadAllText(fileName);
        File.WriteAllText("output.txt", content.ToUpper());
        Console.WriteLine("Готово, результат в output.txt");
    }
}

