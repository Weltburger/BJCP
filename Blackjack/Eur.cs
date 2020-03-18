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

                Card card3 = retCard(deck);
                b.addCardToPCardList(card3);

                a.BankerCard1Game.ImageLocation = card3.Image;
                a.BankerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;
                a.BankerCard2Game.Visible = true;
                displayCardBack(a.BankerCard2Game);

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
                Card card = retCard(deck);
                b.addCardToPCardList(card);

                takingCards(a, card);
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
                    usualRules(a, GlobalData.gameType);
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
