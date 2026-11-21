//8.1
using System;

class BankAccount
{
    public string Owner;
    public decimal Balance;

    public BankAccount(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public static void Transfer(BankAccount from, BankAccount to, decimal sum)
    {
        if (from.Balance < sum)
        {
            Console.WriteLine("Недостаточно средств!");
            return;
        }
        from.Balance -= sum;
        to.Balance += sum;
    }

    public void Show() => Console.WriteLine($"{Owner}: {Balance} руб.");
}

class Program
{
    static void Main()
    {
        var acc1 = new BankAccount("Иванов", 5000);
        var acc2 = new BankAccount("Петров", 1000);

        BankAccount.Transfer(acc1, acc2, 1500);

        acc1.Show();
        acc2.Show();
    }
}

