using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public interface IRegisterLogic
    {
        string getName();
        bool checkFileExistence(string name);
        bool checkFill(string name_, string pas1, string pas2, string email_);
        bool regPassMatch(string rePass);
        void writeInfo();
    }
}
