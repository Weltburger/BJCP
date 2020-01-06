using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public interface IGameType
    {
        void Reset(PlayForm a);
        void Start(PlayForm a);
        void Deal(PlayForm a);
        void End(PlayForm a);
        void Insurance(PlayForm a);
        void Surrender(PlayForm a);
        void Double(PlayForm a);
    }
}
