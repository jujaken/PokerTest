namespace PokerTest;

public static class ConsoleHelpers
{
    public static void View(Game game)
    {
        Console.WriteLine("Players:");
        foreach (var player in game.Players)
        {
            Console.WriteLine(player.Name);
            foreach (var card in player.Cards)
                Console.WriteLine(card.ToString());
        }
        Console.WriteLine("Table:");
        foreach (var card in game.TableCards)
            Console.WriteLine(card.ToString());
    }
}
