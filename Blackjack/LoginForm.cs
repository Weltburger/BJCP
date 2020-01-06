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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CrNewAccLabel_MouseEnter(object sender, EventArgs e)
        {
            alredyHaveLabel.ForeColor = Color.FromArgb(100, 35, 63);
        }

        private void CrNewAccLabel_MouseLeave(object sender, EventArgs e)
        {
            alredyHaveLabel.ForeColor = Color.FromArgb(210, 45, 73);
        }

        private void CloseBtnLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccLabel_MouseEnter(object sender, EventArgs e)
        {
            createAccLabel.ForeColor = Color.FromArgb(100, 35, 63);
        }

        private void CreateAccLabel_MouseLeave(object sender, EventArgs e)
        {
            createAccLabel.ForeColor = Color.FromArgb(210, 45, 73);
        }

        private void CreateAccLabel_Click(object sender, EventArgs e)
        {
            signUpPanel.Visible = false;
        }

        private void AlredyHaveLabel_Click(object sender, EventArgs e)
        {
            signUpPanel.Visible = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            ILoginLogic lg = new LoginLogic(logPlayerNameTextBox.Text, logPasswordTextBox.Text);

            if (lg.getPas() != "")  // Если поле пароля не пустое
            {
                if(lg.getMatch())   //Если пароли совпадают
                {
                    GlobalData.PlayerName = lg.getName();
                    GlobalData.INIg = new IniFiles(lg.getName() + ".ini");
                    Form load = new Loading();
                    load.Show();
                    this.Hide();
                }
            }
            else
            {
                Notification.Show("All fields must be filled in!", NotifType.Warning);
            }
        }

        private void RegiserButton_Click(object sender, EventArgs e)
        {
            IRegisterLogic rg = new RegisterLogic(playerNmTextBox.Text, passwordTextBox.Text, rePasswordTextBox.Text, emailTextbox.Text);

            if (rg.checkFill(playerNmTextBox.Text, passwordTextBox.Text, rePasswordTextBox.Text, emailTextbox.Text))    // Проверка заполенности полей
            {
                if (!rg.checkFileExistence(playerNmTextBox.Text)) // Если файла не существует, создаем новый
                {
                    if (rg.regPassMatch(rePasswordTextBox.Text))    // Совпадение паролей
                    {
                        GlobalData.PlayerName = rg.getName();
                        rg.writeInfo();    // Заполнить поля в файле
                        Notification.Show("The account was successfully created", NotifType.Confirm);
                        GlobalData.INIg = new IniFiles(rg.getName() + ".ini");
                        Form load = new Loading();
                        load.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
