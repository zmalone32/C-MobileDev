//Name: Zechariah Malone
//Class: INFO 1200
//Section: 002
//Professor: Crandall
//Date: 11/17/2019
//Project #: 8_B
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZMFitnessApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyWaterPage : ContentPage
	{
        // Public objects
        string today = "";
        string docPath = "";
        string docName = "";
        string fileStored = "";
        int water = 0;
        
        /// <summary>
        /// This is to show the amount of water intake each day
        /// </summary>
		public MyWaterPage ()
		{
			InitializeComponent ();

            // Display Date and also update or create a txt file if not created yet
            today = DateTime.Now.ToShortDateString();

            LblDate.Text = $"Today: {today}";
            string fileDate = today.Replace('/', '_');
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docName = $"{today}water.txt";
            fileStored = Path.Combine(docPath, docName);

            // update file if one is not created yet or create one if ther is not one
            if (File.Exists(fileStored))
            {
                water = int.Parse(File.ReadAllText(fileStored));
                LblWater.Text = water.ToString();

                DisplayWater(water);
            }
            // create new file and display if file for today is not found
            else
            {
                DisplayAlert("No Water Found", "You have not drank any water today", "Close");
                File.WriteAllText(fileStored, water.ToString());
            }
		}

        /// <summary>
        /// Method to called the stacklayout and loop until the correct number or whater images is displayed
        /// </summary>
        /// <param name="water"></param>
        private void DisplayWater(int water)
        {
            SLWater.Children.Clear();
            // Add another water image 
            for (int i = 0; i < water; i++)
            {
                SLWater.Children.Add(new Image { Source = "Water.jpg", HeightRequest = 50 });
            }
        }

        /// <summary>
        /// Add water image if the state ment is valid, if not, display the congratulations alert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            // Add water up until 8 glasses
            if (water < 8)
            {
                water++;
                File.WriteAllText(fileStored, water.ToString());
                LblWater.Text = water.ToString();
                DisplayWater(water);
            }
            // Display the congrats alert
            else
            {
                DisplayAlert("Water Intake Complete", "You've hit your goal of drinking 8 glasses of water today!", "Close");
            }
        }

        /// <summary>
        /// Close the window and go back to the main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddWater_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}