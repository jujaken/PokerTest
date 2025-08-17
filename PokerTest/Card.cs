namespace PokerTest;

public enum Suit
{
    Diamonds,
    Clubs,
    Hearts,
    Spades,
}

public enum Advantage
{
    N2,N3,N4,N5,N6,N7,N8,N9,N10,
    J, Q, K, Ace
}

public record Card(Suit Suit, Advantage Advantage)
{
    public override string ToString()
    {
        var s = Suit switch
        {
            Suit.Spades => "♠",
            Suit.Hearts => "♥",
            Suit.Clubs => "♣",
            Suit.Diamonds => "♦",
            _ => throw new NotImplementedException()
        };

        var a = Advantage switch
        {
            Advantage.N2 => "2",
            Advantage.N3 => "3",
            Advantage.N4 => "4",
            Advantage.N5 => "5",
            Advantage.N6 => "6",
            Advantage.N7 => "7",
            Advantage.N8 => "8",
            Advantage.N9 => "9",
            Advantage.N10 => "10",
            Advantage.J => "J",
            Advantage.Q => "Q",
            Advantage.K => "K",
            Advantage.Ace => "",
            _ => throw new NotImplementedException()
        };

        return s + a;
    }
}
