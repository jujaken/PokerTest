using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokerTest.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mix(object sender, RoutedEventArgs e)
        {
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

            Table.Children.Clear();
            game.TableCards.ForEach(card =>
            {
                var cardView = new Card() { Margin = new Thickness(5), RenderTransformOrigin = new(.5, .5) };
                cardView.SetCard(card);
                Table.Children.Add(cardView);
                var translateTransform = new TranslateTransform();
                cardView.RenderTransform = translateTransform;
                AnimateElement(cardView, translateTransform);
            });

            Player.Children.Clear();
            juja.Cards.ForEach(card =>
            {
                var cardView = new Card() { Margin = new Thickness(5), RenderTransformOrigin = new(.5, .5) };
                cardView.SetCard(card);
                Player.Children.Add(cardView);
                var translateTransform = new TranslateTransform();
                cardView.RenderTransform = translateTransform;
                AnimateElement(cardView, translateTransform);
            });

            HighCard.IsChecked = true;
        }

        private void Search(object sender, RoutedEventArgs e)
        {

        }

        private void AnimateElement(UIElement element, TranslateTransform translateTransform)
        {
            element.RenderTransform = new TranslateTransform();

            translateTransform.X = 0; // Начальная позиция по X
            translateTransform.Y = MainGrid.ActualHeight; // Начальная позиция по Y (внизу)

            var translateYAnimation = new DoubleAnimation(MainGrid.ActualHeight, 100, TimeSpan.FromSeconds(1)); // Перемещение вверх
            var opacityAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1)); // Появление

            // Применяем анимации к Transform и Opacity
            translateTransform.BeginAnimation(TranslateTransform.YProperty, translateYAnimation);
            element.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
        }
    }
}