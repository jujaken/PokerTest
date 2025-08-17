namespace PokerTest;

public class Krupie(Random? random = null)
{
    public Random Random { get; set; } = random ?? Random.Shared;

    public Deck Deck { get; set; } = new Deck();

    public void Mix()
    {
        Deck.SetDefault();
        MixCurrent();
    }

    public void MixCurrent()
    {
        var cards = Deck.GetCards();

        for (var i = 0; i < cards.Length; i++)
        {
            var newPos = Random.Next(0, cards.Length);
            (cards[newPos], cards[i]) = (cards[i], cards[newPos]);
        }

        Deck = new Deck(cards);
    }
}
