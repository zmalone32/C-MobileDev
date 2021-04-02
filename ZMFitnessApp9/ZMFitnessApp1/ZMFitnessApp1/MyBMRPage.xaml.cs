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
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZMFitnessApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyBMRPage : ContentPage
	{
        // Constants for all of the calculations
        const int FML_BMR_NUM = 655;
        const double FML_WGHT_MULT = 4.35;
        const double FML_HGHT_MULT = 4.7;
        const double FML_AGE_MULT = 4.7;
        const int ML_BMR_NUM = 66;
        const double ML_WGHT_MULT = 6.23;
        const double ML_HGHT_MULT = 12.7;
        const double ML_AGE_MULT = 6.8;
        const double LITTLE_EX = 1.2;
        const double LIGHT_EX = 1.375;
        const double MODERATE_EX = 1.55;
        const double HEAVY_EX = 1.725;
        const double VERY_HEAVY_EX = 1.9;


		public MyBMRPage ()
		{
			InitializeComponent ();
            PckActivity.SelectedIndex = 0;
            PckGender.SelectedIndex = 0;
		}
        /// <summary>
        /// Calculate the BMR results for males and females.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            // Added from the project assignment
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
            var modalPage = new MyBMRPage();
            modalPage.Disappearing += (sender2, e2) =>
            {
                waitHandle.Set();
            };
            await Navigation.PushModalAsync(modalPage);
            await Task.Run(() => waitHandle.WaitOne());

            double activityMultiplier = 1;

            switch(PckActivity.SelectedItem.ToString())
            {
                // activity multiplier for very light activity
                case "Very Light Activity":
                    activityMultiplier = LITTLE_EX;
                    break;
                // multiplier for light activity
                case "Light Activity":
                    activityMultiplier = LIGHT_EX;
                    break;
                // multiplier for moderate activity
                case "Moderate Activty":
                    activityMultiplier = MODERATE_EX;
                    break;
                // multiplier for heavy activity
                case "Heavy Activity":
                    activityMultiplier = HEAVY_EX;
                    break;
                // multiplier for very heave activity
                case "Very Heavy Activity":
                    activityMultiplier = VERY_HEAVY_EX;
                    break;
            }

            // statement to calculate the bmr based on activity
            if (PckGender.SelectedItem.ToString() == "Male")
            {
                //results if it is a male
                LblResults.Text = ((ML_BMR_NUM + (ML_WGHT_MULT * FitnessGlobalVariables.ProfWeight) + (ML_HGHT_MULT * FitnessGlobalVariables.ProfHeight) - (ML_AGE_MULT * FitnessGlobalVariables.ProfAge))*activityMultiplier).ToString("n2");
            }
            else
            {
                // results if it a female
                LblResults.Text = ((FML_BMR_NUM + (FML_WGHT_MULT * FitnessGlobalVariables.ProfWeight) + (FML_HGHT_MULT * FitnessGlobalVariables.ProfHeight) - (FML_AGE_MULT * FitnessGlobalVariables.ProfAge))*activityMultiplier).ToString("n2");
            }

            // Calculate Female BMR
           // LblFemaleResults.Text = (FML_BMR_NUM + (FML_WGHT_MULT * FitnessGlobalVariables.ProfWeight) + (FML_HGHT_MULT * FitnessGlobalVariables.ProfHeight) - (FML_AGE_MULT * FitnessGlobalVariables.ProfAge)).ToString("n2");

            // Calculate Male BMR
            //LblMaleResults.Text = (ML_BMR_NUM + (ML_WGHT_MULT * FitnessGlobalVariables.ProfWeight) + (ML_HGHT_MULT * FitnessGlobalVariables.ProfHeight) - (ML_AGE_MULT * FitnessGlobalVariables.ProfAge)).ToString("n2");
        }
        /// <summary>
        /// Close the fitness calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            // Closes out of the pop up window
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}