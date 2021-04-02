using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesignACar
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button to compile the care price, make, color, and condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDesignCar_Clicked(object sender, EventArgs e)
        {
            // Declare variables for the car
            decimal price = 0;
            string make = "";
            string color = "";
            string condition = "";
            
            // If statement will replace results label with the price string
            if (ValidCarPrice(ref price))
            {
                LblResults.Text = price.ToString();
                make = GetMakeOfCar();
                // This will throw the make of the car
                if (make != "")
                {
                    GetCarColor(ref color);
                    // This will return the color of the car or the display alert if not input correctly
                    if (color != "")
                    {
                        condition = SwtchCondition.IsToggled ? "New" : "Used";
                        //____Condition__=____?__true__:__False__
                        DisplayMyCoolCar(condition, make, color, price);
                    }
                }
            }
        }

        /// <summary>
        /// This is to reference the condition, make, color, and price of car in the results
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="make"></param>
        /// <param name="color"></param>
        /// <param name="price"></param>
        private void DisplayMyCoolCar(string condition, string make, string color, decimal price)
        {
            LblResults.Text = $"{condition} {color} {make} for {price.ToString("c")}";
        }
        
        /// <summary>
        /// This is to reference the color of the car as a string
        /// </summary>
        /// <param name="color"></param>
        private void GetCarColor(ref string color)
        {
            // If statement to Display color or alert if no input
            if (PckColor.SelectedIndex > -1)
            {
                color = PckColor.SelectedItem.ToString();

            }
            else
            {
                DisplayAlert("Invalid Input", "Please select a car color.", "Close");
                color = "";
            }
            // color = PckColor.SelectedIndex > -1 ? PckColor.SelectedItem.ToString() : "";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetMakeOfCar()
        {
            // if statement to return the make or a display alert
            if (PckMake.SelectedIndex > -1)
            {
                return PckMake.SelectedItem.ToString();

            }
            else
            {
                DisplayAlert("Invalid Input", "Please select a car make", "Close");
                return "";
            }

        }

        /// <summary>
        /// True false to return if it is a valid car price
        /// </summary>
        /// <param name="carPrice"></param>
        /// <returns></returns>
        private bool ValidCarPrice(ref decimal carPrice)
        {
            // retun car price is it matches the condition
            if (decimal.TryParse(EntryPrice.Text, out carPrice))
            {
                return true;
            }
            else
            {
                DisplayAlert("Ivalid Input", "Please enter a numnber for the price", "Close");
                return false;
            }
        }
       
    }
}
