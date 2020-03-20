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
    public partial class MainForm : Form
    {
        IReplenishment rep;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            WindowBtn.Visible = true;
            MaximizeBtn.Visible = false;
        }

        private void WindowBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            MaximizeBtn.Visible = true;
            WindowBtn.Visible = false;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SidebarBtnLog_Click(object sender, EventArgs e)
        {
            animLogic();
        }

        private void animLogic()
        {
            if (SidebarWrapper.Width == 300)
            {
                sidebar.Visible = false;
                bunifuSeparator1.Width = 40;
                sidebar.Width = 50;
                SidebarWrapper.Width = 70;
                enabledBtn(true);
                sidebarAnimation.Show(sidebar);
            }
            else
            {
                sidebar.Visible = false;
                bunifuSeparator1.Width = 270;
                sidebar.Width = 280;
                SidebarWrapper.Width = 300;
                enabledBtn(false);
                sidebarBackAnimation.Show(sidebar);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            inGameState(0);
        }

        private void GameBtn_Click(object sender, EventArgs e)
        {
            if (GlobalData.InGameState == false)
            {
                openChildForm(new PlayForm());
                pages.SetPage(1);
            }
            else
            {
                Notification.Show("Finish the game first!", NotifType.Warning);
            }
        }

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            if (inGameState(2))
            {
                IChUpd chStats = new ChartUpdate();
                chStats.favoriteGame(this);
                chStats.UpdateStats(this);
            }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if(inGameState(3))
            {
                if (GlobalData.INIg.ReadINI("User Information", "Photo") != "")
                {
                    yourPhoto.ImageLocation = GlobalData.INIg.ReadINI("User Information", "Photo");
                }
                yourName.Text = GlobalData.INIg.ReadINI("User Information", "Name");
                YouHaveMoney.Text = GlobalData.INIg.ReadINI("User Information", "Money") + "$";

                IProfileStats ps = new ProfileStats();
                ps.favoriteGame(this);
                ps.gmsLost(this);
                ps.gmsPlayed(this);
                ps.gmsWon(this);
            }
        }

        private void DonationBtn_Click(object sender, EventArgs e)
        {
            if (inGameState(4))
            {
                rep = new Replenishment();
            }
        }

        private void ChsTypeBtn_Click(object sender, EventArgs e)
        {
            inGameState(5);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (GlobalData.InGameState == false)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                Form log = new LoginForm();
                log.Show();
                this.Hide();
            }
            else
            {
                Notification.Show("Finish the game first!", NotifType.Warning);
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(childForm);
            Wrapper.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChngPhoto_MouseEnter(object sender, EventArgs e)
        {
            ChngPhoto.ForeColor = Color.FromArgb(210, 45, 73);
        }

        private void ChngPhoto_MouseLeave(object sender, EventArgs e)
        {
            ChngPhoto.ForeColor = Color.FromArgb(241, 241, 241);
        }

        private void ChngPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Изображения |*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                yourPhoto.ImageLocation = ofd.FileName;
                GlobalData.INIg.Write("User Information", "Photo", ofd.FileName);
            }
        }

        private void DonateLbl_MouseEnter(object sender, EventArgs e)
        {
            DonateLbl.ForeColor = Color.FromArgb(210, 45, 73);
        }

        private void DonateLbl_MouseLeave(object sender, EventArgs e)
        {
            DonateLbl.ForeColor = Color.FromArgb(239, 212, 88);
        }

        private void DonateLbl_Click(object sender, EventArgs e)
        {
            rep = new Replenishment();
            pages.SetPage(4);
        }

        private void USDLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CryptoBtn1_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 1);
        }

        private void CryptoBtn2_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 2);
        }

        private void CryptoBtn3_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 3);
        }

        private void CryptoBtn4_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 4);
        }

        private void CryptoBtn5_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 5);
        }

        private void CryptoBtn6_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 6);
        }

        private void CryptoBtn7_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 7);
        }

        private void CryptoBtn8_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 8);
        }

        private void CryptoBtn9_Click(object sender, EventArgs e)
        {
            rep.cryptoMath(this, 9);
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            rep.proceed();
            USDLbl.Text = "";
            DonMoneyGet.Text = "0$";
            WillGetLbl.Text = "0$";
            HaveToPayLbl.Text = "0$";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Starter.Start();
        }

        private void Starter_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            if(this.Opacity == 100)
            {
                Starter.Stop();
            }
        }

        private bool inGameState(int p)
        {
            if (GlobalData.InGameState == false)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                pages.SetPage(p);
                return true;
            }
            else
            {
                Notification.Show("Finish the game first!", NotifType.Warning);
                return false;
            }
        }

        private void enabledBtn(bool a)
        {
            if (a)
            {
                HomeBtn.Enabled = false;
                GameBtn.Enabled = false;
                StatisticsBtn.Enabled = false;
                ProfileBtn.Enabled = false;
                DonationBtn.Enabled = false;
                ChsTypeBtn.Enabled = false;
                LogoutBtn.Enabled = false;
            }
            else
            {
                HomeBtn.Enabled = true;
                GameBtn.Enabled = true;
                StatisticsBtn.Enabled = true;
                ProfileBtn.Enabled = true;
                DonationBtn.Enabled = true;
                ChsTypeBtn.Enabled = true;
                LogoutBtn.Enabled = true;
            }
        }

        private void USAFlag_MouseEnter(object sender, EventArgs e)
        {
            USAEnd.Stop();
            USAStart.Start();
        }

        private void USAFlag_MouseLeave(object sender, EventArgs e)
        {
            USAStart.Stop();
            USAEnd.Start();
        }

        private void USAStart_Tick(object sender, EventArgs e)
        {
            biggerSize(USAFlag, USAStart);
        }

        private void USAEnd_Tick(object sender, EventArgs e)
        {
            lessSize(USAFlag, USAEnd);
        }

        private void EurFlag_MouseEnter(object sender, EventArgs e)
        {
            EurEnd.Stop();
            EurStart.Start();
        }

        private void EurFlag_MouseLeave(object sender, EventArgs e)
        {
            EurStart.Stop();
            EurEnd.Start();
        }

        private void SpnFlag_MouseEnter(object sender, EventArgs e)
        {
            SpnEnd.Stop();
            SpnStart.Start();
        }

        private void SpnFlag_MouseLeave(object sender, EventArgs e)
        {
            SpnStart.Stop();
            SpnEnd.Start();
        }

        private void EurStart_Tick(object sender, EventArgs e)
        {
            biggerSize(EurFlag, EurStart);
        }

        private void biggerSize(PictureBox pb, Timer t)
        {
            if (pb.Width <= 420)
            {
                pb.Height += 2;
                pb.Width += 2;
            }
            else
            {
                t.Stop();
            }
        }

        private void lessSize(PictureBox pb, Timer t)
        {
            if (pb.Width >= 380)
            {
                pb.Height -= 2;
                pb.Width -= 2;
            }
            else
            {
                t.Stop();
            }
        }

        private void EurEnd_Tick(object sender, EventArgs e)
        {
            lessSize(EurFlag, EurEnd);
        }

        private void SpnStart_Tick(object sender, EventArgs e)
        {
            biggerSize(SpnFlag, SpnStart);
        }

        private void SpnEnd_Tick(object sender, EventArgs e)
        {
            lessSize(SpnFlag, SpnEnd);
        }

        private void USAFlag_Click(object sender, EventArgs e)
        {
            tpGame(1);
        }

        private void EurFlag_Click(object sender, EventArgs e)
        {
            tpGame(2);
        }

        private void SpnFlag_Click(object sender, EventArgs e)
        {
            tpGame(3);
        }

        private void tpGame(int t)
        {
            GlobalData.gameType = t;
            switch (t)
            {
                case 1:
                    Notification.Show("You have chosen the American type of game!", NotifType.Confirm);
                    break;
                case 2:
                    Notification.Show("You have chosen the European type of game!", NotifType.Confirm);
                    break;
                case 3:
                    Notification.Show("You have chosen the Spanish type of game!", NotifType.Confirm);
                    break;
                default:
                    break;
            }
        }
    }
}
