using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokerTest.Wpf
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public const int CardW = 320;
        public const int CardH = 450;
        public const int CardOffsetW = 22;
        public const int CardOffsetH = 30;

        public void SetCard(PokerTest.Card card)
        {
            if (Resources["CardTiles"] is not BitmapImage original) return;
            
            var bitmap = new CroppedBitmap(original, new Int32Rect()
            {
                X = (int)card.Advantage * (CardW + CardOffsetW),
                Y = (int)card.Suit * (CardH + CardOffsetH),
                Width = CardW,
                Height = CardH,
            });

            CardImage.Source = bitmap;
        }
    }
}
