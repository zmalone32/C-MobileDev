using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoinFlip13B
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Flip the coin button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            // Created coin as a method in the class. Constructor method for the coin class to set default values
            Coin coin = new Coin();
            coin.FlipCoin();

            // Display what the result of the coin. 
            DisplayAlert("Coin Result", $"Coin landed on {coin.GetSideUp()}", "Close");
            coin.GetSideUp();

        }
        /// <summary>
        /// flip the coin 5 times and display results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip5x_Clicked(object sender, EventArgs e)
        {
            // Coin method called to throw the string in the list
            Coin coin = new Coin();
            LstViewCoin.ItemsSource = new List<string>();
            List<string> coinList = new List<string>();

            // While Loop - int value to count up to the while loop number
            int count = 0;
            while (count <= 4)
            {
                // coin value is flipped, then added to list and added one more time to loop again
                coin.FlipCoin();
                coinList.Add(coin.GetSideUp());
                count++;
            }

            // For Loop
            //for (int i = 0; i < 5; i++)
            //{
            //    coin.FlipCoin();
            //    coinList.Add(coin.GetSideUp());
            //}

            // Do While Loop
            //do
            //{
            //    coin.FlipCoin();
            //    coinList.Add(coin.GetSideUp());
            //    count++;
            //} while (count < 5);

            // Show coin results in list
            LstViewCoin.ItemsSource = coinList;
        }
    }
}
