using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class RegisterLogic : IRegisterLogic
    {
        private IniFiles INI;
        private string password;
        private string name;
        private string email;

        public RegisterLogic(string name_, string pas, string rePas, string em)
        {
            name = name_;
            password = pas;
            email = em;
        }

        public string getName()
        {
            return this.name;
        }

        public bool checkFileExistence(string name)
        {
            if (System.IO.File.Exists(name + ".ini"))
            {
                Notification.Show("User alredy exist!", NotifType.Warning); // return false;
                return true;                                                // Файл существует
            }
            else
            {
                return false;
            }
        }

        public bool checkFill(string name_, string pas1, string pas2, string email_)
        {
            if (name_ == "" || pas1 == "" || pas2 == "" || email_ == "")
            {
                Notification.Show("All fields must be filled in!", NotifType.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool regPassMatch(string rePass)
        {
            if (this.password == rePass)
            {
                return true;
            }
            else
            {
                Notification.Show("Passwords don't match!", NotifType.Warning);
                return false;
            }
        }

        public void writeInfo()
        {
            INI = new IniFiles(name + ".ini");
            INI.Write("User Information", "Name", name);
            INI.Write("User Information", "Password", password);
            INI.Write("User Information", "Email", email);
            INI.Write("User Information", "Money", "5000");
            INI.Write("User Information", "Photo", "");
            INI.Write("Statistic", "AWins", "0");
            INI.Write("Statistic", "ALoses", "0");
            INI.Write("Statistic", "EWins", "0");
            INI.Write("Statistic", "ELoses", "0");
            INI.Write("Statistic", "SWins", "0");
            INI.Write("Statistic", "SLoses", "0");
        }
    }
}
