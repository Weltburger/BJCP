using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Banker : Member
    {
        public Banker()
        {
            cardList = new List<Card>();

            this.money = 7000000;
        }

        public Card getDCard(int a)
        {
            return this.cardList[a];
        }

        public bool gotAce()
        {
            if (cardList[0].Value == 11)
                return true;
            else
                return false;
        }
    }
}
