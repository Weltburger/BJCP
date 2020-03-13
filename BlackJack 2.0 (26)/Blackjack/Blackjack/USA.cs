using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class USA : Game, IGameType
    {
        public USA()
        {
            this.b = new Banker();
            this.p = new Player();
            this.random = new Random();
            this.deck = new Deck();
        }

        public void Start(PlayForm a)
        {
            makeBet(a, Convert.ToInt32(a.BetGame.Text), p); // проверка ставки
            if (pBet != 0)
            {
                GlobalData.InGameState = true;
                this.betButtonsState(a);
                a.DealBtnGame.Enabled = true;
                a.EndBtnGame.Enabled = true;
                a.StartBtnGame.Enabled = false;

                p.resCardSum();
                b.resCardSum();

                #region init player
                /*int randomCard1 = selectRandomCard(deck.getDeck(), random);
                Card card1 = deck.getDeckCard(randomCard1); //deck[randomCard1];
                p.addUserCards(randomCard1);    //usedCards.Add(randomCard1);
                deck.popCard(card1);
                int randomCard2 = selectRandomCard(deck.getDeck(), random);


                while (p.containsUserCard(randomCard2))
                {
                    randomCard2 = selectRandomCard(deck.getDeck(), random);
                }
                randomCard2 = 1 * randomCard2;

                Card card2 = deck.getDeckCard(randomCard2); //deck[randomCard2];
                deck.popCard(card2);
                p.addUserCards(randomCard2);    //usedCards.Add(randomCard2);

                p.addCardToPCardList(card1);    //playercardList.Add(card1);
                p.addCardToPCardList(card2);    //playercardList.Add(card2);

                a.PlayerCard1Game.ImageLocation = card1.Image;
                a.PlayerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;

                a.PlayerCard2Game.ImageLocation = card2.Image;
                a.PlayerCard2Game.SizeMode = PictureBoxSizeMode.AutoSize;*/
                this.initPlayer(a);
                #endregion

                #region init banker
                int randomCard3 = selectRandomCard(deck.getDeck(), random);
                /*while (p.containsUserCard(randomCard3))
                {
                    randomCard3 = selectRandomCard(deck.getDeck(), random);
                }
                randomCard3 = 1 * randomCard3;*/

                Card card3 = deck.getDeckCard(randomCard3);   //deck[randomCard3];
                deck.popCard(card3);
                p.addUserCards(randomCard3);

                b.addCardToPCardList(card3);

                int randomCard4 = selectRandomCard(deck.getDeck(), random);
                /*while (p.containsUserCard(randomCard4))
                {
                    randomCard4 = selectRandomCard(deck.getDeck(), random);
                }
                randomCard4 = 1 * randomCard4;*/

                Card card4 = deck.getDeckCard(randomCard4);   //deck[randomCard4];
                deck.popCard(card4);
                p.addUserCards(randomCard4);

                b.addCardToPCardList(card4);

                a.BankerCard1Game.ImageLocation = card3.Image;
                a.BankerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;
                displayCardBack(a.BankerCard2Game);
                //a.pictureBox3.ImageLocation = card4.Image;
                //a.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

                #endregion

                p.sumPlayerCards();
                if (b.gotAce())
                {
                    a.InsuranceBtnGame.Enabled = true;
                }
                else if (p.getCardSum() >= 9 && p.getCardSum() <= 13)
                {
                    a.DoubleBtnGame.Enabled = true;
                }
                else if (b.getDCard(0).Value == 10)
                {
                    if (b.checkBlackJack()) // Banker's BJ check
                    {
                        if (p.checkBlackJack()) // Player's BJ check
                        {
                            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                            Notification.Show("Drawn!", NotifType.Warning); 
                            this.showScore(a);
                            a.ResetBtnGame.Enabled = true;
                        }
                        else
                        {
                            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                            Notification.Show("You lose! Banker's got BLACKJACK!", NotifType.Error); 
                            p.updStats(0, 1, pBet);
                            this.showScore(a);
                            a.ResetBtnGame.Enabled = true;//resetGame(a);
                        }
                    }
                }
                else if (p.getCardSum() == 21)
                {
                    if (b.checkBlackJack()) // Banker's BJ check
                    {
                        a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                        Notification.Show("Drawn!", NotifType.Warning);
                        this.showScore(a);
                        a.ResetBtnGame.Enabled = true;
                    }
                    else
                    {
                        a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                        Notification.Show("You win!", NotifType.Confirm);
                        p.updStats(1, 1, pBet);
                        this.showScore(a);
                        a.ResetBtnGame.Enabled = true;
                    }
                }
                else if (b.getDCard(0).Value != 10 || b.getDCard(1).Value != 11)
                {
                    p.sumPlayerCards();
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
                a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                Notification.Show("You lose!", NotifType.Error);
                p.updStats(0, 1, pBet);
                b.sumPlayerCards();
                this.showScore(a);
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
            this.endUpButScore(a);

            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image; // Открытие второй закрытой карты банкира

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
                p4.Location = new Point(324 + 100 + b.getplayerBoxCount() * 100, 156);
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
                if (b.getDCard(0).Value == 11 && b.getDCard(1).Value == 10)
                {
                    p.updStats(1, 1, pBet * 2);
                    Notification.Show("Dealer has got BLACKJACK, but You win!", NotifType.Confirm); 
                    a.ResetBtnGame.Enabled = true;
                }
                else
                {
                    if (b.getCardSum() > 21)
                    {
                        p.updStats(1, 1, pBet);
                        Notification.Show("Dealer has got BLACKJACK, but You win!", NotifType.Confirm); 
                        a.ResetBtnGame.Enabled = true;
                    }
                    else if (p.getCardSum() <= b.getCardSum())
                    {
                        p.updStats(0, 1, pBet);
                        Notification.Show("You lose!", NotifType.Error); 
                        a.ResetBtnGame.Enabled = true;
                    }
                    else
                    {
                        p.updStats(1, 1, pBet);
                        Notification.Show("You win!", NotifType.Confirm); 
                        a.ResetBtnGame.Enabled = true;
                    }
                }
            }
            else
            {
                if (b.getCardSum() > 21)
                {
                    p.updStats(1, 1, pBet);
                    Notification.Show("You win!", NotifType.Confirm); 
                    a.ResetBtnGame.Enabled = true;
                }
                else if (p.getCardSum() <= b.getCardSum())
                {
                    p.updStats(0, 1, pBet);
                    Notification.Show("You lose!", NotifType.Error);
                    a.ResetBtnGame.Enabled = true;
                }
                else
                {
                    p.updStats(1, 1, pBet);
                    Notification.Show("You win!", NotifType.Confirm); 
                    a.ResetBtnGame.Enabled = true;
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
            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
            this.surr(a);
        }

        public void Double(PlayForm a)
        {
            if (p.getMoney() >= pBet * 2)
            {
                this.doubleX2(a);

                a.BankerScore.Text = Convert.ToString(b.getDCard(0).Value);
                a.PlayerScore.Text = Convert.ToString(p.getCardSum());
                if (p.getCardSum() > 21)
                {
                    a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                    p.updStats(0, 1, pBet);
                    Notification.Show("You lose!", NotifType.Error); 
                    a.ResetBtnGame.Enabled = true;
                    b.sumPlayerCards();
                    this.showScore(a);
                }
                else if (p.getCardSum() == 21)
                {
                    End(a);
                }

                a.PlayerScore.Text = Convert.ToString(p.getCardSum());

            }
            else
            {
                Notification.Show("You don't have that amount of money!", NotifType.Warning);
            }

        }
    }
}
