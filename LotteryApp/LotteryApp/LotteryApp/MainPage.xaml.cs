using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LotteryApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        // constant variable that is static
        const int MAX_ARRAY_SIZE = 5;
        //Dynamic vvvvv
        // List<int> lottolist = new List<int>();
        // Multi-Value Integer. Not Dynamic vvvv
        int[] lottoArray = new int[5];
        Random rand = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add in the Genrate random numbers class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlay_Clicked(object sender, EventArgs e)
        {
            // Random Lottery numbers method
            GenerateRandLottoNums();
            DisplayLottoNums();

            // if statement to compare the entry with the random generated numbers
            if (WinnerWinnerChickenDinner())
            {
                DisplayAlert("Winner", "You just won an \"A\" in the class", "Close");
            }
            else
            {
                DisplayAlert("Loser", "You just lost sucker", "Close");
            }
        }

        /// <summary>
        /// Test if the comparison is correct.
        /// </summary>
        /// <returns></returns>
        private bool WinnerWinnerChickenDinner()
        {
            if (lotto1.Text == EntryGuess1.Text && lotto2.Text == EntryGuess2.Text && lotto3.Text == EntryGuess3.Text && lotto4.Text == EntryGuess4.Text && lotto5.Text == EntryGuess5.Text)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// convert the numbers to a string
        /// </summary>
        private void DisplayLottoNums()
        {
            lotto1.Text = lottoArray[0].ToString();
            lotto2.Text = lottoArray[1].ToString();
            lotto3.Text = lottoArray[2].ToString();
            lotto4.Text = lottoArray[3].ToString();
            lotto5.Text = lottoArray[4].ToString();

        }

        /// <summary>
        /// Generate random integers to the lotto array
        /// </summary>
        private void GenerateRandLottoNums()
        {
            // int count = 0;

            //while (count < lottoArray.Length)
            //{
            //    lottoArray[count] = rand.Next(100);
            //    count++;
            //}

            //do
            //{
            //    lottoArray[count] = rand.Next(100);
            //    count++;
            //} while (count < lottoArray.Length);

            for (int i = 0; i < lottoArray.Length; i++)
            {
                lottoArray[i] = rand.Next(100);
            }
        }
    }
}
