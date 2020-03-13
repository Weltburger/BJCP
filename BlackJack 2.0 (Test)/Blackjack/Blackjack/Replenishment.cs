using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Replenishment : IReplenishment
    {
        private int sum = 0;

        public void cryptoMath(MainForm a, int sw)
        {
            if(a.USDLbl.Text != "")
            {
                switch (sw)
                {
                    case 1:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 5);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 5);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 5;
                        break;
                    case 2:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 2);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 2);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 2;
                        break;
                    case 3:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 3);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 3);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 3;
                        break;
                    case 4:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 8);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 8);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 8;
                        break;
                    case 5:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 7);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 7);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 7;
                        break;
                    case 6:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 2);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 2);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 2;
                        break;
                    case 7:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 5);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 5);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 5;
                        break;
                    case 8:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 6);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 6);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 6;
                        break;
                    case 9:
                        a.DonMoneyGet.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 8);
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = Convert.ToString(Convert.ToInt32(a.USDLbl.Text) * 8);
                        sum = Convert.ToInt32(a.USDLbl.Text) * 6;
                        break;
                    default:
                        a.DonMoneyGet.Text = a.USDLbl.Text;
                        a.HaveToPayLbl.Text = a.USDLbl.Text;
                        a.WillGetLbl.Text = a.USDLbl.Text;
                        sum = Convert.ToInt32(a.USDLbl.Text);
                        break;
                }
            }
            else
            {
                Notification.Show("Enter the sum!", NotifType.Warning);
            }
        }

        public void proceed()
        {
            if (sum != 0)
            {
                GlobalData.INIg.Write("User Information", "Money", Convert.ToString(Convert.ToInt32(GlobalData.INIg.ReadINI("User Information", "Money")) + this.sum));
                Notification.Show("Account replenished!", NotifType.Confirm);
            }
            else
            {
                Notification.Show("Enter the sum!", NotifType.Warning);
            }
        }
    }
}
