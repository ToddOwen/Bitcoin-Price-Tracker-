using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Newtonsoft.Json;
using System.Net;

namespace BitcoinPriceTracker
{
    public partial class Form1 : Form
    {



        BackgroundWorker CoinDesk, BlockChain;
        public string CoinPrice;
        public static string json;
        public static decimal lastPrice = 0m, newPrice = 0m;

        private void Form1_Load(object sender, EventArgs e)
        {
            CoinDesk.RunWorkerAsync();
        }

        public Form1()
        {
            InitializeComponent();
            CoinDesk = new BackgroundWorker();
            CoinDesk.DoWork += new DoWorkEventHandler(CoinDeskData);

        }

        public void ChangeText(decimal lastPrice, decimal newPrice)
        {
            this.Invoke((MethodInvoker)delegate { PriceText.Text = CoinPrice; });
            if (newPrice == lastPrice)
                this.Invoke((MethodInvoker)delegate { PriceText.ForeColor = Color.DarkOrange; });
            else if (newPrice > lastPrice)
                this.Invoke((MethodInvoker)delegate { PriceText.ForeColor = Color.Red; });
            else if (newPrice < lastPrice)
                this.Invoke((MethodInvoker)delegate { PriceText.ForeColor = Color.Green; });
        }

        private void CoinDeskData(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                using (var web = new WebClient())
                {
                    var url = @"https://api.coindesk.com/v1/bpi/currentprice.json";
                    json = web.DownloadString(url);

                }

                dynamic obj = JsonConvert.DeserializeObject(json);
                var price = Convert.ToDecimal(obj.bpi.GBP.rate.Value);
                newPrice = price;
                CoinPrice = string.Format("1BTC = {0:C2}", newPrice);
                ChangeText(lastPrice, newPrice);
                lastPrice = newPrice;
                Thread.Sleep(3000);
            }

        }


    }
}
