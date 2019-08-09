using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void TotalCoins_Click(object sender, RoutedEventArgs e){
            int nickels = Int32.Parse(nickelsTB.Text);
            int dimes = Int32.Parse(dimesTB.Text);
            int qrtrs = Int32.Parse(qrtsTB.Text);
            int loons = Int32.Parse(loonsTB.Text);
            int toons = Int32.Parse(toonsTB.Text);
            double nTot = 0, dTot = 0, qTot = 0, lTot = 0, tTot = 0, total = 0;

            if (nickels > 0)
                nTot = nickels * 0.05;

            if (dimes > 0) 
                dTot = dimes * 0.1;

            if (qrtrs > 0)
                qTot = qrtrs * 0.25;

            if (loons > 0)
                lTot = loons;

            if (toons > 0)
                tTot = toons * 2;

            total = nTot + dTot + qTot + lTot + tTot;

            totCoinsTB.Text = total.ToString();
        }

        private void TotalBills_Click(object sender, RoutedEventArgs e) {
            int fives = Int32.Parse(fivesTB.Text);
            int tens = Int32.Parse(tensTB.Text);
            int twnty = Int32.Parse(twntyTB.Text);
            int fifty = Int32.Parse(fiftyTB.Text);
            int hund = Int32.Parse(hundTB.Text);
            double fTot = 0, tTot = 0, twTot = 0, ftyTot = 0, hTot = 0, total = 0;

            if (fives > 0)
                fTot = fives * 5;

            if (tens > 0)
                tTot = tens * 10;

            if (twnty > 0)
                twTot = twnty * 20;

            if (fifty > 0)
                ftyTot = fifty * 50;

            if (hund > 0)
                hTot = hund * 100;

            total = fTot + tTot + twTot + ftyTot + hTot;

            totBillsTB.Text = total.ToString();
        }
    }
}
