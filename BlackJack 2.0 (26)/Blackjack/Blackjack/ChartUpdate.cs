using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class ChartUpdate : IChUpd
    {
        private IniFiles INI;

        public ChartUpdate()
        {
            this.INI = new IniFiles(GlobalData.PlayerName + ".ini");
        }

        public void UpdateStats(MainForm a)
        {
            a.chartStats.Series[0].Points.Clear();

            if (INI.ReadINI("Statistic", "AWins") != "0")
                a.chartStats.Series["s1"].Points.AddXY("American Wins", INI.ReadINI("Statistic", "AWins"));
            if (INI.ReadINI("Statistic", "ALoses") != "0")
                a.chartStats.Series["s1"].Points.AddXY("American Loses", INI.ReadINI("Statistic", "ALoses"));
            if (INI.ReadINI("Statistic", "EWins") != "0")
                a.chartStats.Series["s1"].Points.AddXY("European Wins", INI.ReadINI("Statistic", "EWins"));
            if (INI.ReadINI("Statistic", "ELoses") != "0")
                a.chartStats.Series["s1"].Points.AddXY("European Loses", INI.ReadINI("Statistic", "ELoses"));
            if (INI.ReadINI("Statistic", "SWins") != "0")
                a.chartStats.Series["s1"].Points.AddXY("Spanish Wins", INI.ReadINI("Statistic", "SWins"));
            if (INI.ReadINI("Statistic", "SLoses") != "0")
                a.chartStats.Series["s1"].Points.AddXY("Spanish Loses", INI.ReadINI("Statistic", "SLoses"));
        }

        public void favoriteGame(MainForm a)
        {
            int ag, eg, sg;

            ag = Convert.ToInt32(INI.ReadINI("Statistic", "AWins")) + Convert.ToInt32(INI.ReadINI("Statistic", "ALoses"));
            eg = Convert.ToInt32(INI.ReadINI("Statistic", "EWins")) + Convert.ToInt32(INI.ReadINI("Statistic", "ELoses"));
            sg = Convert.ToInt32(INI.ReadINI("Statistic", "SWins")) + Convert.ToInt32(INI.ReadINI("Statistic", "SLoses"));

            if(ag > eg && ag > sg)
            {
                a.FavGmResLbl.Text = "American";
            }
            else if(eg > ag && eg > sg)
            {
                a.FavGmResLbl.Text = "European";
            }
            else if (sg > ag && sg > eg)
            {
                a.FavGmResLbl.Text = "Spanish";
            }
        }
    }
}
