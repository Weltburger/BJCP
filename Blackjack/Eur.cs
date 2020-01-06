using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Eur : Game, IGameType
    {
        public Eur()
        {
            this.b = new Banker();
            this.p = new Player();
            this.random = new Random();
            this.deck = new Deck();
        }

        public void Start(PlayForm a)
        {
            makeBet(a, Convert.ToInt32(a.BetGame.Text), p); // Взятие ставки
            if (pBet != 0)  // Если ставка сделана
            {
                GlobalData.InGameState = true;
                this.betButtonsState(a);
                a.StartBtnGame.Enabled = false;
                a.EndBtnGame.Enabled = true;
                a.DealBtnGame.Enabled = true;

                p.resCardSum(); // Обнулить сумму карт у игрока
                b.resCardSum(); // Обнулить сумму карт у бинкира

                #region init player
                this.initPlayer(a);
                #endregion


                #region init banker
                int randomCard3 = selectRandomCard(deck.getDeck(), random);
                while (p.containsUserCard(randomCard3))
                {
                    randomCard3 = selectRandomCard(deck.getDeck(), random);
                }
                randomCard3 = 1 * randomCard3;

                Card card3 = deck.getDeckCard(randomCard3);   //deck[randomCard3];
                deck.popCard(card3);
                p.addUserCards(randomCard3);

                b.addCardToPCardList(card3);

                /*int randomCard4 = selectRandomCard(deck.getDeck(), random);
                while (p.containsUserCard(randomCard4))
                {
                    randomCard4 = selectRandomCard(deck.getDeck(), random);
                }
                randomCard4 = 1 * randomCard4;

                Card card4 = deck.getDeckCard(randomCard4);   //deck[randomCard4];
                deck.popCard(card4);
                p.addUserCards(randomCard4);

                b.addCardToPCardList(card4);*/

                a.BankerCard1Game.ImageLocation = card3.Image;
                a.BankerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;
                a.BankerCard2Game.Visible = true;
                displayCardBack(a.BankerCard2Game);
                //a.BankerCard2Game.SizeMode = PictureBoxSizeMode.AutoSize;
                //a.pictureBox3.ImageLocation = card4.Image;
                //a.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

                #endregion

                p.sumPlayerCards(); // Подсчет суммы карт у игрока
                if (b.gotAce())     // Если у банкира на раздаче был туз
                {
                    a.InsuranceBtnGame.Enabled = true;  
                }
                else if (p.getCardSum() == 21)  // Блекджек у игрока
                {
                    p.updStats(1, 2, pBet);
                    Notification.Show("You have got BlackJack! You win!", NotifType.Confirm);
                    a.ResetBtnGame.Enabled = true; 
                }
                else if (p.getCardSum() >= 9 && p.getCardSum() <= 13)
                {
                    a.DoubleBtnGame.Enabled = true;
                }
                else if (b.getDCard(0).Value != 10 && b.getDCard(0).Value != 11)
                {
                    if (p.getCardSum() < 9)
                    {
                        a.SurrenderBtnGame.Enabled = true;
                    }
                }

                a.BankerScore.Text = Convert.ToString(b.getDCard(0).Value);
                a.PlayerScore.Text = Convert.ToString(p.getCardSum());
            }
        }

        public void Reset(PlayForm a)
        {
            this.resetGame(a);
        }

        public void Deal(PlayForm a)
        {
            this.dealSUE(a);

            if (p.getCardSum() > 21)
            {
                p.updStats(0, 2, pBet);
                Notification.Show("You lose!", NotifType.Error);
                a.DealBtnGame.Enabled = false;
                a.EndBtnGame.Enabled = false;
                a.ResetBtnGame.Enabled = true;
            }
            else if (p.getCardSum() == 21)
            {
                End(a);
            }

            a.PlayerScore.Text = Convert.ToString(p.getCardSum());

        }

        public void End(PlayForm a)
        {
            a.BankerCard2Game.Visible = false;
            this.endUpButScore(a);

            while (b.getCardSum() <= 16)
            {
                int randomCard = selectRandomCard(deck.getDeck(), random);
                Card card = deck.getDeckCard(randomCard);
                p.addUserCards(randomCard);

                if (p.containsUserCard(randomCard))
                {
                    randomCard = selectRandomCard(deck.getDeck(), random);
                }
                else randomCard = 1 * randomCard;

                PictureBox p4 = new PictureBox();
                p4.Width = 71;
                p4.Height = 96;
                p4.Location = new Point(324 + b.getplayerBoxCount() * 100, 156);
                p4.ImageLocation = card.Image;
                p4.SizeMode = PictureBoxSizeMode.AutoSize;
                a.Controls.Add(p4);


                b.addPlayerBox(p4);

                b.addCardToPCardList(card);
                deck.popCard(card);
                b.sumPlayerCards();
            }
            if (p.isPlSur())
            {
                if (b.getDCard(0).Value == 11 && b.getDCard(1).Value == 10 || b.getDCard(0).Value == 10 && b.getDCard(1).Value == 11)
                {
                    p.updStats(1, 2, pBet * 2);
                    Notification.Show("Dealer has got BLACKJACK, but You win!", NotifType.Confirm);
                    a.ResetBtnGame.Enabled = true;
                }
                else
                {
                    if (b.getCardSum() > 21)
                    {
                        p.updStats(1, 2, pBet);
                        Notification.Show("You win!", NotifType.Confirm);
                        a.ResetBtnGame.Enabled = true;
                    }
                    else if (p.getCardSum() <= b.getCardSum())
                    {
                        p.updStats(0, 2, pBet);
                        Notification.Show("You lose!", NotifType.Error);
                        a.ResetBtnGame.Enabled = true; 
                    }
                    else
                    {
                        p.updStats(1, 2, pBet);
                        Notification.Show("You win!", NotifType.Confirm);
                        a.ResetBtnGame.Enabled = true; 
                    }
                }
            }
            else
            {
                if (p.checkBlackJack())
                {
                    if (b.checkBlackJack())
                    {
                        Notification.Show("Drawn!", NotifType.Warning);
                        a.ResetBtnGame.Enabled = true; 
                    }
                    else
                    {
                        p.updStats(1, 2, pBet);
                        Notification.Show("You got BLACKJACK! You win!", NotifType.Confirm);
                        a.ResetBtnGame.Enabled = true; 
                    }
                }
                else
                {
                    if (b.getCardSum() > 21)
                    {
                        p.updStats(1, 2, pBet);
                        Notification.Show("You win!", NotifType.Confirm);
                        a.ResetBtnGame.Enabled = true; 
                    }
                    else if (p.getCardSum() <= b.getCardSum())
                    {
                        p.updStats(0, 2, pBet);
                        Notification.Show("You lose!", NotifType.Error);
                        a.ResetBtnGame.Enabled = true; 
                    }
                    else
                    {
                        p.updStats(1, 2, pBet);
                        Notification.Show("You win!", NotifType.Confirm);
                        a.ResetBtnGame.Enabled = true; 
                    }
                }
            }

            this.showScore(a);

        }

        public void Insurance(PlayForm a)
        {
            this.insuranceGN(a);
        }

        public void Surrender(PlayForm a)
        {
            this.surr(a);
        }

        public void Double(PlayForm a)
        {
            if (p.getMoney() >= pBet * 2)
            {
                this.doubleX2(a);

                if (p.getCardSum() > 21)
                {
                    p.updStats(0, 2, pBet);
                    Notification.Show("You lose!", NotifType.Error);
                    a.ResetBtnGame.Enabled = true;
                }
                else if (p.getCardSum() == 21)
                {
                    End(a);
                }
            }
            else
            {
                Notification.Show("You don't have that amount of money!", NotifType.Warning);
            }

            a.PlayerScore.Text = Convert.ToString(p.getCardSum());

        }
    }
}
