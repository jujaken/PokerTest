using PokerTest;

var game = new Game();

var juja = new Player(1, "Juja");
game.Players.Add(juja);

game.StartGame();

juja.Cards.Add(game.Krupie.Deck.Next());
juja.Cards.Add(game.Krupie.Deck.Next());

game.TableCards.Add(game.Krupie.Deck.Next());
game.TableCards.Add(game.Krupie.Deck.Next());
game.TableCards.Add(game.Krupie.Deck.Next());
game.TableCards.Add(game.Krupie.Deck.Next());
game.TableCards.Add(game.Krupie.Deck.Next());

TxtHelper.View(game);
