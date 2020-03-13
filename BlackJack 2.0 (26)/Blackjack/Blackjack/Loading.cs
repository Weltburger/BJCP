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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = Convert.ToString(circularProgressBar1.Value);
            if(circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                Form main = new MainForm();
                main.Show();
                //this.Hide();
                this.Close();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            this.NmLbl.Text = GlobalData.PlayerName;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
