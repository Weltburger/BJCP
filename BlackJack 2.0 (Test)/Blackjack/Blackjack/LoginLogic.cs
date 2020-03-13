using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class LoginLogic : ILoginLogic
    {
        private IniFiles INI;
        private string password;
        private string name;

        public LoginLogic(string name_, string pas)
        {
            name = name_;
            password = pas;

            INI = new IniFiles(name + ".ini");
        }

        public string getName()
        {
            return this.name;
        }

        public string getPas()
        {
            return this.password;
        }

        public bool getMatch()
        {
            if (checkFileExistence(name))
            {
                if (password != INI.ReadINI("User Information", "Password"))  // Проверка совпадения паролей
                {
                    Notification.Show("Passwords do not match!", NotifType.Error);
                    return false; // Пароли не совпадают
                }
                else
                {
                    return true;  // Пароли совпадают
                }
            }
            else
            {
                return false;
            }
        }

        public bool checkFileExistence(string name)
        {
            if (System.IO.File.Exists(name + ".ini"))
            {
                return true;
            }
            else
            {
                Notification.Show("User does not exist!", NotifType.Error);//return false;
                return false;
            }
        }
    }
}
