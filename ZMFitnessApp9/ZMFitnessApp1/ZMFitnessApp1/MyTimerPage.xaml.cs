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
using Xamarin.Forms.Xaml;

namespace ZMFitnessApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyTimerPage : ContentPage
	{
        //
        const int MINUTE = 60;
        const int DOUBLE_DIGIT = 10;
        int lapCount = 0;
        public MyTimerPage ()
		{
			InitializeComponent ();
		}

        private async Task StartTimer()
        {
            await Task.Delay(1000);

        }

        private async void BtnStartTime_Clicked(object sender, EventArgs e)
        {

            if (PckUpDown.SelectedItem.ToString() == "Down")
            {
                await CountDown();
            }
            else
            {
                await CountUp();
            }
            //if (int.TryParse(EntryTime.Text, out int userSeconds))
            //{
            //    BtnStartTime.IsEnabled = false;
            //    while (userSeconds >= 0)
            //    {
            //        // Convert user seconds to minutes
            //        int minutes = userSeconds / MINUTE;

            //        // Calculate the user time to seconds
            //        int seconds = userSeconds % MINUTE;

            //        // If Double Digit for minutes
            //        if (minutes >= DOUBLE_DIGIT)
            //        {
            //            // 
            //            if (seconds >= DOUBLE_DIGIT)
            //            {
            //                // Display Time
            //                LblTime.Text = minutes + ":" + seconds;


            //            }
            //            else
            //            {
            //                //LblTime.Text = minutes + ":0" + seconds;
            //                LblTime.Text = $"{minutes}:{seconds}";
            //            }
            //        }
            //        else
            //        {
            //            // If else to define when the digits are lower than 10
            //            if (seconds >= DOUBLE_DIGIT)
            //            {
            //                // Display Time
            //                LblTime.Text = "0" + minutes + ":" + seconds;


            //            }
            //            else
            //            {
            //                // If time is less than 10 digits in minutes and seconds
            //                LblTime.Text = "0" + minutes + ":0" + seconds;
            //            }



            //            // If there is an invalid integer input, this will be shown
            //            await DisplayAlert("Invalid Input", "Please enter an integer for the seconds", "Close");
            //        }




            //        await StartTimer();
            //        userSeconds--;

            //    }
            //    BtnStartTime.IsEnabled = true;
            //}
        }

        private async Task CountUp()
        {
            if (int.TryParse(EntryTime.Text, out int time))
            {
                BtnStartTime.IsEnabled = false;
                int i = 0;
                while (time >= i)
                {
                    DisplayTime(i);
                    Task task = StartTimer();
                    await task;
                    i++;
                }
            }
            else
            {
                await DisplayAlert("Invalid Input", "Please enter a number for the time", "Close");
            }
            BtnStartTime.IsEnabled = true;
        }

        private async Task CountDown()
        {
            if (int.TryParse(EntryTime.Text, out int time))
            {
                BtnStartTime.IsEnabled = false;
                while (time >= 0)
                {
                    DisplayTime(time);
                    Task task = StartTimer();
                    await task;
                    time--;
                }
            }
            else
            {
                await DisplayAlert("Invalid Input", "Please enter a number for the time", "Close");
            }
            BtnStartTime.IsEnabled = true;
        }

        private void DisplayTime(int time)
        {
            int minutes = time / MINUTE;
            int seconds = time % MINUTE;

            if (minutes >= DOUBLE_DIGIT)
            {
                if (seconds >= DOUBLE_DIGIT)
                {
                    LblTime.Text = $"{minutes}:{seconds}";
                }
                else
                {
                    LblTime.Text = $"{minutes}:0{seconds}";
                }
            }
            else
            {
                if (seconds >= DOUBLE_DIGIT)
                {
                    LblTime.Text = $"0{minutes}:{seconds}";
                }
                else
                {
                    LblTime.Text = $"0{minutes}:0{seconds}";
                }
            }
        }

        private void BtnCloseTime_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BtnLapTime_Clicked(object sender, EventArgs e)
        {
            lapCount++;
            LblLapTime.Text = LblLapTime.Text + $" [Lap: {lapCount} - {LblTime.Text}] ";
        }
    }
}