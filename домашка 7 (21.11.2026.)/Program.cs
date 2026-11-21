//упражнение 8.4
using System;

class Program
{
    static void Check(object obj)
    {
        if (obj is IFormattable)
            Console.WriteLine($"{obj} — реализует IFormattable (is)");
        else
            Console.WriteLine($"{obj} — не реализует IFormattable (is)");

        IFormattable f = obj as IFormattable;
        Console.WriteLine(f != null
            ? $"{obj} — реализует IFormattable (as)"
            : $"{obj} — не реализует IFormattable (as)");
    }

    static void Main()
    {
        Check(42);
        Check(3.14);
        Check(DateTime.Now);
        Check(new Program());
    }
}
