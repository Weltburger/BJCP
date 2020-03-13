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
    public partial class Notification : Form
    {
        public Notification(string mesText, NotifType type)
        {
            InitializeComponent();

            NotificationText.Text = mesText;

            switch (type)
            {
                case NotifType.Confirm:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case NotifType.Error:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[1];
                    break;
                case NotifType.Info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[2];
                    break;
                case NotifType.Warning:
                    this.BackColor = Color.FromArgb(255, 180, 50);
                    icon.Image = imageList1.Images[3];
                    break;
            }
            this.Width = NotificationText.Width + 150;
        }

        public static void Show(string mesText, NotifType type)
        {
            new Blackjack.Notification(mesText, type).Show();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            timerShow.Start();
        }

        private void CloseBtnLog_Click(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
        }

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
        }

        private int interval = 0;

        private void TimerShow_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                timerShow.Stop();
            }
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }
    }
}
