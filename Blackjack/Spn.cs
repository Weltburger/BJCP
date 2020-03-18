using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Spn : Game, IGameType
    {
        public Spn()
        {
            this.b = new Banker();
            this.p = new Player();
            this.random = new Random();
            this.deck = new Deck();
            this.douCount = 0;
            this.spnSpec = false;
        }

        public void Start(PlayForm a)
        {
            makeBet(a, Convert.ToInt32(a.BetGame.Text), p); // проверка ставки
            if (pBet != 0)
            {
                int randomCard5 = 8;
                Card card5 = deck.getDeckCard(randomCard5);
                deck.popCard(card5);
                randomCard5 = 20;
                card5 = deck.getDeckCard(randomCard5);
                deck.popCard(card5);
                randomCard5 = 32;
                card5 = deck.getDeckCard(randomCard5);
                deck.popCard(card5);
                randomCard5 = 44;
                card5 = deck.getDeckCard(randomCard5);
                deck.popCard(card5);

                GlobalData.InGameState = true;
                this.betButtonsState(a);
                a.EndBtnGame.Enabled = true;
                a.DealBtnGame.Enabled = true;
                a.StartBtnGame.Enabled = false;

                p.resCardSum();
                b.resCardSum();

                #region init player

                this.initPlayer(a);

                #endregion

                #region init banker

                Card card3 = retCard(deck);
                b.addCardToPCardList(card3);

                Card card4 = retCard(deck);
                b.addCardToPCardList(card4);

                a.BankerCard1Game.ImageLocation = card3.Image;
                a.BankerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;
                displayCardBack(a.BankerCard2Game);

                #endregion

                p.sumPlayerCards();

                a.BankerScore.Text = Convert.ToString(b.getDCard(0).Value);
                a.PlayerScore.Text = Convert.ToString(p.getCardSum());

                if (b.gotAce())
                {
                    a.InsuranceBtnGame.Enabled = true;
                    a.SurrenderBtnGame.Enabled = true;
                }
                else if (p.getCardSum() == 21)
                {
                    if (b.checkBlackJack()) // Banker's BJ check
                    {
                        a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                        p.updStats(1, 3, (pBet*3)/2);
                        Notification.Show("You win! 3/2", NotifType.Confirm);
                        this.showScore(a);
                        a.ResetBtnGame.Enabled = true;
                    }
                    else
                    {
                        a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                        p.updStats(1, 3, pBet);
                        Notification.Show("You win!", NotifType.Confirm); 
                        this.showScore(a);
                        a.ResetBtnGame.Enabled = true;
                    }
                }
                else if (p.getCardSum() >= 9 && p.getCardSum() <= 13)
                {
                    a.DoubleBtnGame.Enabled = true;
                    a.SurrenderBtnGame.Enabled = true;
                }
                else if (b.getDCard(0).Value == 10)
                {
                    a.SurrenderBtnGame.Enabled = true;
                    if (b.checkBlackJack()) // Banker's BJ check
                    {
                        if (p.checkBlackJack()) // Player's BJ check
                        {
                            a.SurrenderBtnGame.Enabled = false;
                            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                            p.updStats(1, 3, (pBet*3)/2);
                            Notification.Show("You win! 3/2", NotifType.Confirm);
                            this.showScore(a);
                            a.ResetBtnGame.Enabled = true;//resetGame(a);
                        }
                        else
                        {
                            a.SurrenderBtnGame.Enabled = false;
                            a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                            p.updStats(0, 3, pBet);
                            Notification.Show("You lose! Banker has got BLACKJACK!", NotifType.Error); 
                            this.showScore(a);
                            a.ResetBtnGame.Enabled = true;//resetGame(a);
                        }
                    }
                }
                else
                {
                    a.SurrenderBtnGame.Enabled = true;
                }
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
                p.updStats(0, 3, pBet);
                Notification.Show("You lose!", NotifType.Error); 
                b.sumPlayerCards();
                this.showScore(a);
                a.DealBtnGame.Enabled = false;
                a.EndBtnGame.Enabled = false;
                a.ResetBtnGame.Enabled = true;//resetGame(a);
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
                Card card = retCard(deck);
                b.addCardToPCardList(card);

                takingCards(a, card);
            }
            if (p.isPlSur())
            {
                if (b.getDCard(0).Value == 11 && b.getDCard(1).Value == 10)
                {
                    p.updStats(1, 3, pBet * 2);
                    Notification.Show("Dealer has got BLACKJACK, but You win!", NotifType.Confirm);
                    a.ResetBtnGame.Enabled = true;//resetGame(a);
                }
                else
                {
                    if (douCount == 0)
                    {
                        specialRules(a);
                        if (!spnSpec)
                            usualRules(a, GlobalData.gameType);
                    }
                    else
                    {
                        usualRules(a, GlobalData.gameType);
                    }
                }
            }
            else
            {
                if (douCount == 0)
                {
                    specialRules(a);
                    if (!spnSpec)
                        usualRules(a, GlobalData.gameType);
                }
                else
                {
                    usualRules(a, GlobalData.gameType);
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

                if (p.getCardSum() > 21)
                {
                    a.BankerCard2Game.ImageLocation = b.getDCard(1).Image;
                    p.updStats(0, 3, pBet);
                    Notification.Show("You lose!", NotifType.Error); 
                    this.showScore(a);
                    a.ResetBtnGame.Enabled = true;
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

        public void specialRules(PlayForm a)
        {
            if ((p.getCardCount() == 3 &&
                            ((p.getCard(0).Value == 6 && p.getCard(1).Value == 7 && p.getCard(2).Value == 8) ||
                            (p.getCard(0).Value == 6 && p.getCard(1).Value == 8 && p.getCard(2).Value == 7) ||
                            (p.getCard(0).Value == 8 && p.getCard(1).Value == 7 && p.getCard(2).Value == 6) ||
                            (p.getCard(0).Value == 8 && p.getCard(1).Value == 6 && p.getCard(2).Value == 7) ||
                            (p.getCard(0).Value == 7 && p.getCard(1).Value == 8 && p.getCard(2).Value == 6) ||
                            (p.getCard(0).Value == 7 && p.getCard(1).Value == 6 && p.getCard(2).Value == 8))))
            {
                p.updStats(1, 3, pBet * 2);
                Notification.Show("You win! Combination of 6, 7 and 8 cards!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;//resetGame(a);
                spnSpec = true;
            }
            else if (p.getCardCount() == 3 && p.getCard(0).Value == 7 && p.getCard(1).Value == 7 && p.getCard(2).Value == 7)
            {
                p.updStats(1, 3, pBet * 3);
                Notification.Show("You win! Combination of 3 cards valued as 7!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;//resetGame(a);
                spnSpec = true;
            }
            else if (p.getCardCount() == 5 && p.getCardSum() == 21)
            {
                p.updStats(1, 3, Convert.ToInt32(3 * pBet / 2));
                Notification.Show("You win! Combination of 5 cards!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;//resetGame(a);
                spnSpec = true;
            }
            else if (p.getCardCount() == 6 && p.getCardSum() == 21)
            {
                p.updStats(1, 3, pBet * 2);
                Notification.Show("You win! Combination of 5 cards!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;//resetGame(a);
                spnSpec = true;
            }
            else if (p.getCardCount() == 7 && p.getCardSum() == 21)
            {
                p.updStats(1, 3, pBet * 3);
                Notification.Show("You win! Combination of 5 cards!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;//resetGame(a);
                spnSpec = true;
            }
        }
    }
}
