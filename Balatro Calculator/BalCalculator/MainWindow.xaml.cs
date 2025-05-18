using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace BalCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// Global reference list of card base effects (Enhancement)
    public enum CardBase
    {
        None,
        Bonus,
        Mult,
        Wild,
        Glass,
        Steel,
        Stone,
        Gold,
        Lucky
    }

    /// Global reference list of card ranks
    public enum CardValue
    {
        None,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    /// Global reference list of card suits
    public enum CardSuit
    {
        None,
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    /// Global reference list of card filter effects (Edition)
    public enum CardFilter
    {
        None,
        Foil,
        Holographic,
        Polychrome
    }

    /// Global reference list of card sticker effects (Seal)
    public enum CardSticker
    {
        None,
        Gold,
        Red,
        Blue,
        Purple
    }

    public class Card
    {
        public static int DeckSize = 0;
        // Constructor requires rank and suit, sets rest to default null
        public Card(
            CardValue rank, CardSuit suit,
                CardBase enhancement = CardBase.None,
                CardFilter edition = CardFilter.None,
                CardSticker seal = CardSticker.None
            )
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Enhancement = enhancement;
            this.Edition = edition;
            this.Seal = seal;
            DeckSize++;
        }
        // Holds all info for playing card
        //      Rank #REQUIRED
        //      Suit #REQUIRED
        //      Enhancement (card base) #DEFAULT NULL
        //      Edition (card filter) #DEFAULT NULL
        //      Seal (card sticker) #DEFAULT NULL
        public required CardValue Rank { get; set; }
        public required CardSuit Suit { get; set; }
        public CardBase Enhancement { get; set; }
        public CardFilter Edition { get; set; }
        public CardSticker Seal { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void ButtonSetCard_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
        //    {
        //        lstNames.Items.Add(txtName.Text);
        //        txtName.Clear();
        //    }
        //}
    }
}