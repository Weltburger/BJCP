using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class ProfileStats : IProfileStats
    {
        public void favoriteGame(MainForm a)
        {
            int ag, eg, sg;

            ag = Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "AWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ALoses"));
            eg = Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "EWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ELoses"));
            sg = Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SLoses"));

            if (ag > eg && ag > sg)
            {
                a.GmsFavLbl.Text = "American";
            }
            else if (eg > ag && eg > sg)
            {
                a.GmsFavLbl.Text = "European";
            }
            else if (sg > ag && sg > eg)
            {
                a.GmsFavLbl.Text = "Spanish";
            }
        }

        public void gmsPlayed(MainForm a)
        {
            int pld = 0;

            pld += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "AWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ALoses"));
            pld += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "EWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ELoses"));
            pld += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SWins")) + Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SLoses"));

            a.GmsPlayedLbl.Text = Convert.ToString(pld);
        }

        public void gmsWon(MainForm a)
        {
            int won = 0;

            won += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "AWins"));
            won += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "EWins"));
            won += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SWins"));

            a.GmsWonLbl.Text = Convert.ToString(won);
        }

        public void gmsLost(MainForm a)
        {
            int lost = 0;

            lost += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ALoses"));
            lost += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "ELoses"));
            lost += Convert.ToInt32(GlobalData.INIg.ReadINI("Statistic", "SLoses"));

            a.GmsLostLbl.Text = Convert.ToString(lost);
        }
    }
}
