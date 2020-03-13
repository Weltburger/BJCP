using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Member
    {
        protected int money;
        protected int cardSum = 0;
        protected List<Card> cardList;
        public List<PictureBox> playerbox = new List<PictureBox>();
        protected bool BJState = false;

        public virtual bool checkBlackJack()
        {
            if (this.cardList[0].Value == 10 && this.cardList[1].Value == 11 || this.cardList[0].Value == 11 && this.cardList[1].Value == 10)
                BJState = true;
            return BJState;
        }

        public virtual void resCardSum()
        {
            this.cardSum = 0;
        }

        public virtual void clearCardList()
        {
            this.cardList.Clear();
        }

        public int getCardSum()
        {
            return this.cardSum;
        }

        public virtual void addCardToPCardList(Card a)
        {
            this.cardList.Add(a);
        }

        public virtual void sumPlayerCards()
        {
            cardSum = 0;
            for (int i = 0; i < cardList.Count; i++)
            {
                cardSum += cardList[i].Value;
            }
            if (cardSum > 21)
            {
                foreach (Card c in cardList)
                {
                    if (c.Value == 11)
                    {
                        cardSum -= 10;
                        if (cardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public virtual int getplayerBoxCount()
        {
            return this.playerbox.Count();
        }

        public virtual void addPlayerBox(PictureBox a)
        {
            this.playerbox.Add(a);
        }

        protected void betWin(int a)
        {
            this.money += a;
        }

        protected void betLose(int a)
        {
            this.money -= a;
        }

        public int getMoney()
        {
            return this.money;
        }

        public void negBJState()
        {
            this.BJState = false;
        }
    }
}
