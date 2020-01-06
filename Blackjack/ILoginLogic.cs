using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public interface ILoginLogic
    {
        string getName();
        string getPas();
        bool getMatch();
        bool checkFileExistence(string name);
    }
}
