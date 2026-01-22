using System;

class Program
{
    static void Main()
    {
        Guy joe = new Guy("Joe", 100);
        Guy bob = new Guy("Bob", 50);

        joe.WriteMyInfo();
        bob.WriteMyInfo();

        Console.WriteLine("Joe gir 30 kroner til Bob - Program.cs:13");
        bob.ReceiveCash(joe.GiveCash(30));

        joe.WriteMyInfo();
        bob.WriteMyInfo();
    }
}
