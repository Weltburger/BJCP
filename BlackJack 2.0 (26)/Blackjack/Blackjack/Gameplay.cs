using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Gameplay
    {
        private IGameType gametype;

        public Gameplay(IGameType gt)
        {
            this.gametype = gt;
        }

        public IGameType getGameLogic()
        {
            return this.gametype;
        }
    }
}
