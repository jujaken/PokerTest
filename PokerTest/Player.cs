namespace PokerTest;

public record Player(int Id, string? Name = null)
{
    public List<Card> Cards = [];
}
