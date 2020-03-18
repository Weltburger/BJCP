using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public abstract class Game
    {
        protected Banker b;
        protected Player p;
        protected Random random;
        protected Deck deck;
        protected int douCount;
        protected bool spnSpec;

        protected int pBet = 0;

        public virtual void sName(string a)
        {
            p.setName(a);
        }

        public virtual void sMoney(int a)
        {
            p.setMoney(a);
        }

        protected virtual void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        protected virtual int selectRandomCard(List<Card> a, Random random)
        {
            int randomCard;
            randomCard = random.Next(0, a.Count());
            return randomCard;
        }

        public virtual void makeBet(PlayForm f, int bet, Player p)
        {
            if (f.BetGame.Text != "0")
            {
                if (Convert.ToInt32(f.BetGame.Text) > p.getMoney())
                {
                    Notification.Show("You don't have that amount of money!", NotifType.Error); 
                    f.BetPlus.Enabled = false;
                    f.BetMinus.Enabled = false;
                    f.DealBtnGame.Enabled = false;
                    f.EndBtnGame.Enabled = false;
                }
                else
                {
                    pBet = Convert.ToInt32(f.BetGame.Text);
                    f.BetGame.Text = "0";
                }
            }
            else if (f.BetGame.Text == "0")
            {
                Notification.Show("Make a bet!", NotifType.Warning);
            }
        }

        protected virtual void clearBet()
        {
            this.pBet = 0;
        }

        protected virtual void showScore(PlayForm a)
        {
            a.BankerScore.Text = Convert.ToString(b.getCardSum());
            a.PlayerScore.Text = Convert.ToString(p.getCardSum());
        }

        protected virtual void resetGame(PlayForm a)
        {
            pBet = 0;
            // Очистка формы и данных у игрока и диллера
            a.PlayerCard1Game.Image = null;
            a.PlayerCard2Game.Image = null;
            a.BankerCard1Game.Image = null;
            a.BankerCard2Game.Image = null;
            betButtonsState(a);
            a.PlayerScore.Text = "0";
            a.BankerScore.Text = "0";

            foreach (PictureBox pb in p.playerbox)
            {
                a.Controls.Remove(pb);
            }
            p.playerbox = new List<PictureBox>();
            foreach (PictureBox pb in b.playerbox)
            {
                a.Controls.Remove(pb);
            }
            b.playerbox = new List<PictureBox>();

            p.resCardSum();
            b.resCardSum();
            p.clearCardList();
            b.clearCardList();
            //p.clearUserCards();
            p.playerNegSur();
            p.negBJState();
            b.negBJState();
            if (GlobalData.gameType == 3)
            {
                douCount = 0;
            }
            deck = new Deck();
            // Работа с кнопками
            a.StartBtnGame.Enabled = true;
            a.InsuranceBtnGame.Enabled = false;
            a.EndBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
            a.DoubleBtnGame.Enabled = false;
            a.DealBtnGame.Enabled = false;
            a.ResetBtnGame.Enabled = false;
            a.BetPlus.Enabled = true;
            a.BetMinus.Enabled = true;
            clearBet();
            a.PlayerMoney.Text = Convert.ToString(p.getMoney());
            GlobalData.InGameState = false;
        }

        protected virtual void betButtonsState(PlayForm a)
        {
            a.BetPlus.Enabled = !a.BetPlus.Enabled;
            a.BetMinus.Enabled = !a.BetMinus.Enabled;
        }

        protected virtual void initPlayer(PlayForm a)
        {
            Card card1 = retCard(deck);
            p.addCardToPCardList(card1);
            Card card2 = retCard(deck);
            p.addCardToPCardList(card2);

            a.PlayerCard1Game.ImageLocation = card1.Image;
            a.PlayerCard1Game.SizeMode = PictureBoxSizeMode.AutoSize;

            a.PlayerCard2Game.ImageLocation = card2.Image;
            a.PlayerCard2Game.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        protected virtual void dealSUE(PlayForm a)
        {
            a.InsuranceBtnGame.Enabled = false;
            a.DoubleBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
            p.resCardSum();

            Card card = retCard(deck);
            p.addCardToPCardList(card);
            
            PictureBox p3 = new PictureBox();
            p3.Width = 71;
            p3.Height = 96;
            p3.Location = new Point(324 + 100 + p.getplayerBoxCount() * 100, 413);
            p3.ImageLocation = card.Image;
            p3.SizeMode = PictureBoxSizeMode.AutoSize;
            a.Controls.Add(p3);
            p.addPlayerBox(p3);
            p.sumPlayerCards();
        }

        protected virtual void endUpButScore(PlayForm a)
        {
            a.InsuranceBtnGame.Enabled = false;
            a.DoubleBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
            a.DealBtnGame.Enabled = false;
            a.EndBtnGame.Enabled = false;
            p.sumPlayerCards();
            b.sumPlayerCards();
        }

        protected virtual void insuranceGN(PlayForm a)
        {
            p.playerSur();
            pBet += pBet / 2;
            a.InsuranceBtnGame.Enabled = false;
            a.DoubleBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
        }

        protected virtual void surr(PlayForm a)
        {
            b.sumPlayerCards();
            p.sumPlayerCards();
            this.showScore(a);
            a.InsuranceBtnGame.Enabled = false;
            a.DealBtnGame.Enabled = false;
            a.DoubleBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
            a.EndBtnGame.Enabled = false;
            Notification.Show("You surrendered!", NotifType.Error);
            p.updStats(0, 1, pBet / 2);
            a.ResetBtnGame.Enabled = true;
        }

        protected virtual void doubleX2(PlayForm a)
        {
            pBet = pBet * 2;

            Card card = retCard(deck);
            p.addCardToPCardList(card);
            
            PictureBox p3 = new PictureBox();
            p3.Width = 71;
            p3.Height = 96;
            p3.Location = new Point(324 + 100 + p.getplayerBoxCount() * 100, 413);
            p3.ImageLocation = card.Image;
            p3.SizeMode = PictureBoxSizeMode.AutoSize;
            a.Controls.Add(p3);
            p.addPlayerBox(p3);
            if(GlobalData.gameType == 3)
            {
                if (douCount < 1)
                    douCount++;
                else
                    a.DoubleBtnGame.Enabled = false;
            }
            else
            {
                a.DoubleBtnGame.Enabled = false;
            }
            a.InsuranceBtnGame.Enabled = false;
            a.SurrenderBtnGame.Enabled = false;
            p.sumPlayerCards();
        }

        protected virtual Card retCard(Deck deck)
        {
            int randomCard = selectRandomCard(deck.getDeck(), random);
            Card card = deck.getDeckCard(randomCard);
            deck.popCard(card);
            return card;
        }

        protected void usualRules(PlayForm a, int gameType)
        {
            if (b.getCardSum() > 21)
            {
                p.updStats(1, gameType, pBet);
                Notification.Show("You win!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;
            }
            else if (p.getCardSum() <= b.getCardSum())
            {
                p.updStats(0, gameType, pBet);
                Notification.Show("You lose!", NotifType.Error);
                a.ResetBtnGame.Enabled = true;
            }
            else
            {
                p.updStats(1, gameType, pBet);
                Notification.Show("You win!", NotifType.Confirm);
                a.ResetBtnGame.Enabled = true;
            }
        }

        protected void takingCards(PlayForm a, Card card)
        {
            PictureBox p4 = new PictureBox();
            p4.Width = 71;
            p4.Height = 96;
            if (GlobalData.gameType != 2)
                p4.Location = new Point(324 + 100 + b.getplayerBoxCount() * 100, 156);
            else
                p4.Location = new Point(324 + b.getplayerBoxCount() * 100, 156);
            p4.ImageLocation = card.Image;
            p4.SizeMode = PictureBoxSizeMode.AutoSize;
            a.Controls.Add(p4);
            b.addPlayerBox(p4);
            b.sumPlayerCards();
        }
    }
}
