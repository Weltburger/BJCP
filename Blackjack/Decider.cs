using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Decider
    {
        private IGameType a;
        private IGameType getEur()
        {
            a = new Eur();
            return a;
        }

        private IGameType getUSA()
        {
            a = new USA();
            return a;
        }

        private IGameType getSpn()
        {
            a = new Spn();
            return a;
        }

        public IGameType decide(int gt)
        {
            if (GlobalData.gameType == 0 || GlobalData.gameType == 1)
            {
                GlobalData.gameType = 1;
                return getUSA();
            }
            else if (GlobalData.gameType == 2)
            {
                return getEur();
            }
            else
            {
                return getSpn();
            }
        }
    }
}
