using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iiCoinFlip
{
    public partial class MainPage : ContentPage
    {
        // Instantiate a new coin object of class Coin
        Coin coin = new Coin();

        // Create a list to store the flip results
        List<string> coinResults = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Flip the coin five times and display the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip5x_Clicked(object sender, EventArgs e)
        {
            // Clear out LstViewcoin
            LstViewCoin.ItemsSource = new List<string>();
            coinResults.Clear();

            // Loop 5 times
            for (int i = 0; i < 5; i++)
            {
                coin.FlipCoin();
                // Add a new item to the array with each iteration

                coinResults.Add(coin.GetSideUp());
            }

            LstViewCoin.ItemsSource = coinResults;

        }

        /// <summary>
        ///   Flip the coin once and display an alert with the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            coin.FlipCoin();
            DisplayAlert("Coin Results", coin.GetSideUp(), "Close");
        }
    }
}
