using System;

class Guy
{
    public string Name;
    public int Cash;

    public Guy(string name, int cash)
    {
        Name = name;
        Cash = cash;
    }

    public void WriteMyInfo()
    {
        Console.WriteLine($"{Name} har {Cash} kroner - Guy.cs:16");
    }

    public int GiveCash(int amount)
    {
        if (amount <= Cash && amount > 0)
        {
            Cash -= amount;
            return amount;
        }
        else
        {
            Console.WriteLine($"{Name} har ikke nok penger! - Guy.cs:28");
            return 0;
        }
    }

    public void ReceiveCash(int amount)
    {
        Cash += amount;
    }
}
