using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Player : Member
    {
        private List<int> usedCards;
        private bool sur;
        private string name;
        private IniFiles INI;

        public Player()
        {
            cardList = new List<Card>();
            this.name = GlobalData.PlayerName;
            this.usedCards = new List<int>();
            this.playerbox = new List<PictureBox>();
            INI = new IniFiles(name + ".ini");
            this.money = Convert.ToInt32(INI.ReadINI("User Information", "Money"));
            sur = false;
            GlobalData.money = this.money;
        }

        public void clearUserCards()
        {
            this.usedCards.Clear();
        }

        public void addUserCards(int a)
        {
            this.usedCards.Add(a);
        }

        public bool containsUserCard(int a)
        {
            return this.usedCards.Contains(a);
        }

        public void playerSur()
        {
            this.sur = true;
        }

        public void playerNegSur()
        {
            this.sur = false;
        }

        public void setMoney(int a)
        {
            this.money = a;
        }

        public bool isPlSur()
        {
            if (this.sur)
                return true;
            else
                return false;
        }

        public void setName(string a)
        {
            this.name = a;
        }

        public string getName()
        {
            return this.name;
        }

        public void updStats(int state, int type, int mny)
        {
            if(state == 0)
            {
                if(type == 1)
                {
                    this.INI.Write("Statistic", "ALoses", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "ALoses")) + 1));
                }
                else if(type == 2)
                {
                    this.INI.Write("Statistic", "ELoses", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "ELoses")) + 1));
                }
                else if(type == 3)
                {
                    this.INI.Write("Statistic", "SLoses", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "SLoses")) + 1));
                }

                this.betLose(mny);
                this.INI.Write("User Information", "Money", Convert.ToString(this.money));
                GlobalData.money = this.money;
            }
            else if (state == 1)
            {
                if (type == 1)
                {
                    this.INI.Write("Statistic", "AWins", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "AWins")) + 1));
                }
                else if (type == 2)
                {
                    this.INI.Write("Statistic", "EWins", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "EWins")) + 1));
                }
                else if (type == 3)
                {
                    this.INI.Write("Statistic", "SWins", Convert.ToString(Convert.ToInt32(this.INI.ReadINI("Statistic", "SWins")) + 1));
                }

                this.betWin(mny);
                this.INI.Write("User Information", "Money", Convert.ToString(this.money));
                GlobalData.money = this.money;
            }
        }
    }
}
