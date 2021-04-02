//Name: Zechariah Malone
//Class: INFO 1200
//Section: 002
//Professor: Crandall
//Date: 09/21/2019
//Project #: 3_B
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
using Xamarin.Forms.Xaml;

namespace ZMFitnessApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyProfilePage : ContentPage
	{
        const int MAX_WEIGHT = 1000;
        const int MIN_WEIGHT = 50;
        const int MAX_HEIGHT = 96;
        const int MIN_HEIGHT = 48;
        const int MAX_AGE = 120;
        const int MIN_AGE = 12;

		public MyProfilePage ()
		{
			InitializeComponent ();
		}
        /// <summary>
        /// Close out the my profile page and grab the associated data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            // Grab the entry data from Weight, Height, and Age
            //try{
            //    FitnessGlobalVariables.ProfWeight = double.Parse(WeightEntry.Text);
            //}
            //catch
            if (double.TryParse(WeightEntry.Text, out double userWeight) && userWeight >= MIN_WEIGHT && userWeight <= MAX_WEIGHT)
            {
                // statement to validate the min or max height
                if (double.TryParse(HeightEntry.Text, out double userHeight) && userHeight >= MIN_HEIGHT && userHeight <= MAX_HEIGHT)
                {
                    // statement to validate the min or max age
                    if (double.TryParse(AgeEntry.Text, out double userAge) && userAge >= MIN_AGE && userAge <= MAX_AGE)
                    {
                        // maintain the variable from the global pull
                        FitnessGlobalVariables.ProfWeight = double.Parse(WeightEntry.Text);
                        FitnessGlobalVariables.ProfHeight = double.Parse(HeightEntry.Text);
                        FitnessGlobalVariables.ProfAge = double.Parse(AgeEntry.Text);
                        // pop up the results and go to the page
                        Application.Current.MainPage.Navigation.PopModalAsync();
                    }
                    else
                    {
                        // alert if age input is incorrect
                        DisplayAlert("Invalid Entry", $"Please enter a number for the Age between {MIN_AGE} and {MAX_AGE}", "Close");
                    }

                }
                else
                {
                    // alert if height input is incorrect
                    DisplayAlert("Invalid Entry", $"Please enter a number for the Height between {MIN_HEIGHT} and {MAX_HEIGHT}", "Close");
                }
            }
            else
            {
                // alert if wieght input is incorrect
                DisplayAlert("Invalid Entry", $"Please enter a number for the weight between {MIN_WEIGHT} and {MAX_WEIGHT}", "Close");
            }
                    //{
                
                // }
              //  try { 
                     //   FitnessGlobalVariables.ProfHeight = double.Parse(HeightEntry.Text);
           // }
          //  catch {
                
        }
                 //  try
                  //  {
                 //       FitnessGlobalVariables.ProfAge = double.Parse(AgeEntry.Text);
                  //  }
                  //  catch
                   // {
               
              //  }

                // Button to go back to the main page
          //  Application.Current.MainPage.Navigation.PopModalAsync();
          // }
        /// <summary>
        /// Display the before image and hide the after image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBefore_Clicked(object sender, EventArgs e)
        {
            // Grab the before image from the source
            ImgBefore.Source = "beforepic.jpg";
            // Display the before image
            ImgBefore.IsVisible = true;
            // Hide the after image
            ImgAfter.IsVisible = false;
        }
        /// <summary>
        /// Display the after image and hide the before image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfter_Clicked(object sender, EventArgs e)
        {
            // Grab the after image from the source
            ImgAfter.Source = "afterpic.jpg";
            // Show the after image
            ImgAfter.IsVisible = true;
            // Hide the before image
            ImgBefore.IsVisible = false;

            // Display the congrantulation alert
            DisplayAlert("Good Job", "You're doing great", "Close");
        }
        /// <summary>
        /// Clear all the entries button and also global variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            // Clear all of the variables in the entry boxes
            FirstNameEntry.Text = string.Empty;
            LastNameEntry.Text = string.Empty;
            PreferedNameEntry.Text = string.Empty;
            WeightEntry.Text = string.Empty;
            HeightEntry.Text = string.Empty;
            AgeEntry.Text = string.Empty;
            WeightEntry.Focus();
            
            // Clear the Global Variables
            FitnessGlobalVariables.ProfWeight = 0;
            FitnessGlobalVariables.ProfHeight = 0;
            FitnessGlobalVariables.ProfAge = 0;

        }
    }
}