using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class PlayForm : Form
    {
        Decider dc = new Decider();
        Gameplay obj;
        IGameType gt = new USA();

        public PlayForm()
        {
            InitializeComponent();
            gt = dc.decide(GlobalData.gameType);
            obj = new Gameplay(gt);
        }

        private void BetPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(BetGame.Text) < 500)
            {
                BetGame.Text = Convert.ToString(Convert.ToInt32(BetGame.Text) + 10);
            }
        }

        private void BetMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(BetGame.Text) > 0)
            {
                BetGame.Text = Convert.ToString(Convert.ToInt32(BetGame.Text) - 10);
            }
        }

        private void StartBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Start(this);
        }

        private void EndBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().End(this);
        }

        private void DealBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Deal(this);
        }

        private void DoubleBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Double(this);
        }

        private void InsuranceBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Insurance(this);
        }

        private void SurrenderBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Surrender(this);
        }

        private void ResetBtnGame_Click(object sender, EventArgs e)
        {
            obj.getGameLogic().Reset(this);
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            if (GlobalData.INIg.ReadINI("User Information", "Photo") != "")
            {
                yourPhoto.ImageLocation = GlobalData.INIg.ReadINI("User Information", "Photo");
            }
            PlayerMoney.Text = Convert.ToString(GlobalData.money);
        }
    }
}
