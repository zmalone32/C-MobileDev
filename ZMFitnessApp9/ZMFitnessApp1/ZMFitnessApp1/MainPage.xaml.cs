//Name: Zechariah Malone
//Class: INFO 1200
//Section: 002
//Professor: Crandall
//Date: 11/2/2019
//Project #: 7_B
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZMFitnessApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Display the current date in the text box
            LblDate.Text = DateTime.Now.ToString("d");
        }
        /// <summary>
        /// Display the alert when the welcome screen is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWelcome_Clicked(object sender, EventArgs e)
        {   // Pop up display alert on welcome screen
            DisplayAlert("Welcome", "Welcome to Zechariah's Fitness App", "Close");
        }
        /// <summary>
        /// Navigate to the My Profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMyProfile_Clicked(object sender, EventArgs e)
        {   // Button to go to My Profile Page
            Navigation.PushAsync(new MyProfilePage());
        }
        /// <summary>
        /// Button to go to the BMR page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBMR_Clicked(object sender, EventArgs e)
        {
            // Navigate to the BMR page after button is pressed
            Navigation.PushModalAsync(new MyBMRPage());
        }

        private void BtnTimer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyTimerPage());
        }

        private void BtnMyWater_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyWaterPage());
        }
    }
}
