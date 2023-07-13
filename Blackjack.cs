using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CSharpBlackjack
{
    public partial class Form1 : Form
    {
        List<char> types = new List<char>()
        {
            '2', '3', '4', '5', '6', '7', '8', '9', '0', 'J', 'Q', 'K', 'A'
        };
        List<char> suits = new List<char>()
        {
            'C', 'S', 'H', 'D'
        };
        Random rnd = new Random();
        List<Card> playerHand = new List<Card>();
        List<Card> activeCards = new List<Card>();
        List<PictureBox> cardImages = new List<PictureBox>();
        List<PictureBox> dealerImages = new List<PictureBox>();
        int yourScore = 0;
        int winCount = 0;
        int lossCount = 0;
        bool aceInHand = false;
        bool aceTaken = false;
        int imageLocation = 240;
        public Form1()
        {
            InitializeComponent();
        }

        public void addCardToHand(List<Card> hand, List<Card> activeCards)
        {
            bool dupe = false;
            Card newCard;
            while (true)
            {
                dupe = false;
                newCard = new Card(types[rnd.Next(13)], suits[rnd.Next(4)]);
                for (int i = 0; i < activeCards.Count(); i++)
                {
                    if (newCard.getType() == activeCards[i].getType() && newCard.getSuit() == activeCards[i].getSuit())
                    {
                        dupe = true;
                        break;
                    }
                }
                if (!dupe)
                {
                    break;
                }
            }
            if (newCard.getType() == 'A')
            {
                aceInHand = true;
            }
            hand.Add(newCard);
            activeCards.Add(newCard);
        }

        private void generateCardImage(Card card, List<PictureBox> imageList)
        {
            string cardName = Char.ToString(card.getType()) + Char.ToString(card.getSuit()) + ".png";
            Console.WriteLine(card.getType());
            Console.WriteLine(card.getSuit());
            PictureBox newCard = new PictureBox
            {
                Name = cardName,
                Location = new Point(imageLocation, 60),
                Size = new Size(117,171),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = Image.FromFile(
                    Path.Combine(
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "card-images\\" + cardName))
            };
            imageLocation += 25;
            this.Controls.Add(newCard);
            newCard.BringToFront();
            imageList.Add(newCard);
        }

        private void button1_Click(object sender, EventArgs e) //Deal New Hand
        {
            title.Text = "Your turn.";
            hitButton.Visible = true;
            stopButton.Visible = true;
            dealerTotal.Visible = false;
            yourTotal.Location = new Point(12, 267);
            aceInHand = false;
            aceTaken = false;
            playerHand.Clear();
            activeCards.Clear();
            for (int i = 0; i < cardImages.Count(); i++)
            {
                Controls.Remove(cardImages[i]);
                cardImages[i].Dispose();
            }
            cardImages.Clear();
            for (int i = 0; i < dealerImages.Count(); i++)
            {
                Controls.Remove(dealerImages[i]);
                dealerImages[i].Dispose();
            }
            dealerImages.Clear();
            imageLocation = 240;
            addCardToHand(playerHand, activeCards);
            addCardToHand(playerHand, activeCards);
            Console.WriteLine(playerHand[0].getType());
            Console.WriteLine(playerHand[0].getSuit());
            generateCardImage(playerHand[0], cardImages);
            generateCardImage(playerHand[1], cardImages);
            yourScore = playerHand[0].getValue() + playerHand[1].getValue();
            if (aceInHand)
            {
                yourTotal.Text = "Your Score:" + yourScore + " or " + (yourScore - 10);
            }
            else
            {
                yourTotal.Text = "Your Score:" + yourScore;
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            addCardToHand(playerHand, activeCards);
            generateCardImage(playerHand[playerHand.Count()-1], cardImages);
            yourScore += playerHand[playerHand.Count()-1].getValue();
            if (yourScore > 21 && aceInHand && !aceTaken)
            {
                yourScore = (yourScore - 10);
                yourTotal.Text = "Your Score:" + yourScore;
                aceTaken = true;
            }
            else if (aceInHand && !aceTaken)
            {
                yourTotal.Text = "Your Score:" + yourScore + " or " + (yourScore - 10);
            }
            else
            {
                yourTotal.Text = "Your Score:" + yourScore;
            }
            if (yourScore > 21)
            {
                hitButton.Visible = false;
                stopButton.Visible = false;
                title.Text = "Bust!";
                lossCount += 1;
                losses.Text = "Losses: " + lossCount;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            imageLocation = 40;
            yourTotal.Location = new Point(-180, 250);
            dealerTotal.Visible = true;
            for (int i = 0; i < cardImages.Count(); i++)
            {
                cardImages[i].Location = new Point(imageLocation, 60);
                imageLocation += 25;
            }
            List<Card> dealerHand = new List<Card>();
            aceInHand = false;
            aceTaken = false;
            addCardToHand(dealerHand, activeCards);
            addCardToHand(dealerHand, activeCards);
            int dealerScore = dealerHand[0].getValue() + dealerHand[1].getValue();
            while (dealerScore <= 21 && dealerScore <= yourScore)
            {
                addCardToHand(dealerHand, activeCards);
                dealerScore += dealerHand[dealerHand.Count() - 1].getValue();
                if (dealerScore > 21 && aceInHand && !aceTaken)
                {
                    dealerScore = (dealerScore - 10);
                    aceTaken = true;
                }
            }
            imageLocation = 360;
            for (int i = 0; i < dealerHand.Count(); i++)
            {
                generateCardImage(dealerHand[i], dealerImages);
            }
            if (dealerScore > 21)
            {
                dealerTotal.Text = "Dealer Score:" + dealerScore;
                title.Text = "You win!";
                winCount += 1;
                wins.Text = "Wins: " + winCount;
            }
            else
            {
                dealerTotal.Text = "Dealer Score:" + dealerScore;
                title.Text = "You lose!";
                lossCount += 1;
                losses.Text = "Losses: " + lossCount;
            }
            hitButton.Visible = false;
            stopButton.Visible = false;
        }
    }
}

public class Card
    {
        private char type;
        private char suit;
        private int value;

        public Card(char newType, char newSuit)
        {
            type = newType;
            suit = newSuit;
            if (newType == '0' || newType == 'J' || newType == 'Q' || newType == 'K') {
                value = 10;
            }
            else if (newType == 'A')
            {
                value = 11;
            }
            else
            {
                value = (int)Char.GetNumericValue(newType);
            }
        }

        public char getType()
        {
            return type;
        }

        public char getSuit()
        {
            return suit;
        }

        public int getValue()
        {
            return value;
        }
    }