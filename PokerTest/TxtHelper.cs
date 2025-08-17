using System.Text;

namespace PokerTest
{
    public static class TxtHelper
    {
        public static void View(Game game, string path = "output.txt")
        {
            var output = new StringBuilder();

            output.AppendLine("Players:");
            foreach (var player in game.Players)
            {
                output.AppendLine(player.Name);
                foreach (var card in player.Cards)
                    output.AppendLine(card.ToString());
            }
            output.AppendLine("Table:");
            foreach (var card in game.TableCards)
                output.AppendLine(card.ToString());

            File.WriteAllText(path, output.ToString());
        }
    }
}
