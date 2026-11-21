//дом задание 8.1
using System;
using System.IO;

class Program
{
    static void SearchMail(ref string s)
    {
        int pos = s.IndexOf('#');
        s = (pos >= 0 ? s.Substring(pos + 1) : "").Trim();
    }

    static void Main()
    {
        if (!File.Exists("people.txt"))
            File.WriteAllText("people.txt",
                "Иванов Иван Иванович # iviviv@mail.ru\nПетров Петр Петрович # petr@mail.ru");

        string[] lines = File.ReadAllLines("people.txt");
        string result = "";

        foreach (string line in lines)
        {
            string s = line;
            SearchMail(ref s);
            if (s != "") result += s + Environment.NewLine;
        }

        File.WriteAllText("emails.txt", result);
        Console.WriteLine("Файл emails.txt создан:");
        Console.Write(result);
    }
}

