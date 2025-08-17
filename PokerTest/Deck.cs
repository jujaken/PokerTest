namespace PokerTest;

public class Deck
{
    private Stack<Card> cards = [];

    public Deck()
    {
        SetDefault();
    }

    public Deck(Stack<Card> cards)
    {
        this.cards = cards;
    }

    public Deck(Card[] cards)
    {
        this.cards = new Stack<Card>(cards);
    }

    public void SetDefault()
    {
        cards.Clear();

        for (Suit suit = 0; suit <= Suit.Spades; suit++)
            for (Advantage advantage = 0; advantage <= Advantage.Ace; advantage++)
                cards.Push(new Card(suit, advantage));
    }

    public Card Next()
        => cards.Pop();

    public Card[] GetCards()
    {
        return [.. cards];
    }

    public Deck Clone()
    {
        return new Deck(cards);
    }
}