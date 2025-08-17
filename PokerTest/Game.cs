namespace PokerTest;

public enum PokerHand
{
    HighCard,
    OnePair,
    TwoPair,
    ThreeOfAKind,
    Straight,
    Flush,
    FullHouse,
    FourOfAKind,
    StraightFlush,
    RoyalFlush
}

public class Game
{
    public Krupie Krupie { get; set; } = new Krupie();
    public List<Player> Players { get; set; } = [];

    public List<Player> InGamePlayers { get; set; } = [];
    public List<Player> FallPlayers { get; set; } = [];

    public int RoundNum { get; private set; } = 1;
    public List<Card> TableCards { get; set; } = [];

    public void StartGame()
    {
        InGamePlayers = [.. Players];
        FallPlayers.Clear();
        Krupie.Mix();
    }

    public void FallPlayer(Player player)
    {
        InGamePlayers.Remove(player);
        FallPlayers.Add(player);
        if (Players.Count > 1) return;
        EndGame();
    }

    public void EndGame()
    {

    }

    //// дописать
    //public (PokerHand, Player) FindWinner()
    //{
    //    var hand = PokerHand.HighCard;
    //    var high = Players.MaxBy(p => p.Cards.Max(c => c.Advantage))!;
    //    var winner = high;

    //    foreach(var ply in Players)
    //    {
    //        var allCards = TableCards.Union(ply.Cards);

    //        foreach(var advantageGroup in allCards.GroupBy(c => c.Advantage))
    //        {
    //            if (advantageGroup.Count() == 5)
    //            {
    //                if (hand < PokerHand.Flush)
    //                {
    //                    hand = PokerHand.Flush;
    //                    winner = ply;
    //                }
    //            }
    //        }

    //        //var pairs = allCards.GroupBy(c => c.Advantage).Where(g => g.Count() == 2);

    //    }

    //    //var royalFlush = Players.Select(p =>
    //    //{
    //    //    var allCards = TableCards.Union(p.Cards);
    //    //});

    //    return (hand, winner);
    //}
}
