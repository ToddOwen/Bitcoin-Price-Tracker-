using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;



namespace BitcoinPriceTracker
{
    public partial class Form1 : Form
    {

        public const string DefaultAddress = "1Lrdu3KHirkfTom5QZX9pGB6K2CPHvoebS";
        public string CoinPrice, address = DefaultAddress;
        DateTime lastChange, timeNow, walletUpdatedLast;

        public decimal lastPrice = 0m, newPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private async void CoinDeskAPITimer_Tick(object sender, EventArgs e)
        {
            newPrice = await BitcoinTracking.GetPrice(newPrice);
            CoinPrice = string.Format("1 BTC = {0:C2}", newPrice);
            if (newPrice != lastPrice)
            {
                lastChange = DateTime.Now;
            }

            ChangePrice(ref lastPrice, newPrice);
            if (timeNow.AddMinutes(10) >= walletUpdatedLast)
            {
                updateWallet();
                walletUpdatedLast = timeNow;
            }
        }

        public async void updateWallet()
        {
            timeNow = DateTime.Now;
            try
            {
                WalletText.Text = await BitcoinTracking.GetWalletValue(lastPrice, address);
            }
            catch (Exception e)
            {
                address = DefaultAddress;
                MessageBox.Show(e.ToString());
            }
            
        }

        public decimal ChangePrice(ref decimal lastPrice, decimal newPrice)
        {
            PriceText.Text = CoinPrice;
            timeNow = DateTime.Now;
            if (timeNow >= lastChange.AddSeconds(3))
            {
                image.Image = Properties.Resources.if_Bitcoin_272914;
                PriceText.ForeColor = Color.DarkOrange;
            }
            else if (newPrice > lastPrice)
            {
                PriceText.ForeColor = Color.Red;
                image.Visible = true;
                image.Image = Properties.Resources.if_Arrow_Down_20277;
                //Console.Beep(2000, 200);
                //Console.Beep(2500, 200);
            }
            else if (newPrice < lastPrice)
            {
                PriceText.ForeColor = Color.Green;
                image.Visible = true;
                image.Image = Properties.Resources.if_Arrow_Up_20279;
                //Console.Beep(3000, 100);
                //Console.Beep(3500, 150);

            }
            return lastPrice = newPrice;
        }


        private bool mouseDown;
        private Point lastLocation;

        private void WalletText_DoubleClick(object sender, EventArgs e)
        {
            address = Interaction.InputBox("Enter Wallet Address", "Wallet Address", address);
            address = address.Trim();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


    }
}
