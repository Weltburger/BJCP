using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public interface IProfileStats
    {
        void favoriteGame(MainForm a);
        void gmsPlayed(MainForm a);
        void gmsWon(MainForm a);
        void gmsLost(MainForm a);
    }
}
