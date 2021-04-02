using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZMFitnessApp1
{
    public partial class FoodDetailsPage : ContentPage
    {
        // So I was a bit confused on the public partial class task. I think that is what messed most of the code up down below. 
        List<FoodDetailsPage> foodNames = new List<FoodDetailsPage>();
        [XamlCompilation(XamlCompilationOptions.Compile)]

        List<FoodItems> foodItems = new List<FoodItems>();
        public FoodDetailsPage()
        {
            InitializeComponent();
            // Load the food.txt file
            LoadFood();
        }

        /// <summary>
        /// Load the file and read the array within. 
        /// </summary>
        private void LoadFood()
        {
            // Read the file from the selected directory below
            var assembly = IntrospectionExtensions.GetTypeInfo(TypeInfo(FoodDetailsPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("ZMFitnessApp1.food.txt");

            using (StreamReader sr = new StreamReader(stream))
            {
                // While look to ensure that the code is read all the way through
                while (!sr.EndOfStream)
                {
                    // For each item that is selected, display the other details about it
                    string[] tempFood = sr.ReadLine().Split('\t');
                    PckFood.Items.Add(tempFood[0]);
                    FoodItem food = new FoodItem();
                    {
                        // Array is ordered in which details come up first
                        FoodItem.Category = tempFood[0];
                        FoodItem.FoodName = tempFood[1]:
                        FoodItem.Measurement = tempFood[2];
                        FoodItem.Calories = int.Parse(tempFood[3]);
                    }
                    FoodNames.Add(FoodItem);
                    PckFood.ItemsSource = FoodNames
                }
            }
        }
        /// <summary>
        /// Used to select the information about the fruit once it is selected from the picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodItem selectedFood = new FoodItem();

            // When the food is selected, display the details about that food when it is selected. 
            foreach (FoodItem food in FoodItems)
            {
                if (food.FoodName == PckFood.SelectedItem.ToString())
                {
                    selectedFood = food;
                }
            }
            // Concatenation of the details to create the alert
            DisplayAlert(selectedFood.FoodName, $"Category: {selectedFood.Category}\n\n" + $"Measurement: {selectedFood.Measurement}\n\n" + $"Calories: {selectedFood.Calories.ToString("n0")}", "Close");
        }
        /// <summary>
        /// Not using the Details button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetails_Clicked(object sender, EventArgs e)
        {
            // Not using the details button. Just leave displayed
        }

    }
}