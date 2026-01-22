using System;

class CardPicker
{
    static Random random = new Random();

    public static string PickCard()
    {
        string[] values = { "Ace", "2", "3", "4", "5", "6", "7",
                            "8", "9", "10", "Jack", "Queen", "King" };

        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        string value = values[random.Next(values.Length)];
        string suit = suits[random.Next(suits.Length)];

        return value + " of " + suit;
    }
}
