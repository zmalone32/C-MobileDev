using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeatingChart
{
    public partial class MainPage : ContentPage
    {
        // Constants in the public class
        const int MAX_ROW = 5;
        const int MAX_COL = 3;
        const int MIN_ROW = 0;
        const int MIN_COL = 0;

        
        // Array of seat prices for each row and column
        decimal[,] seatPrices =
        {
            { 450m, 450m, 450m, 450m },
            { 425m, 425m, 425m, 425m },
            { 400m, 400m, 400m, 400m },
            { 375m, 375m, 375m, 375m },
            { 375m, 375m, 375m, 375m },
            { 350m, 350m, 350m, 350m }
        };

        public MainPage()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Display the price of the selected seats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisplayPrice_Clicked(object sender, EventArgs e)
        {
            // Variables to ensure that ther is a valid value selected
            int row = -1;
            int col = -1;

            // Validate the row and column to show the price when the seats are selected.
            if (ValidRow(ref row) && ValidColumn(ref col))
            {
                DisplaySeatPrice(row, col);
            }
        }


        /// <summary>
        /// Display the Seat price into the label below
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void DisplaySeatPrice(int row, int col)
        {
            LblResults.Text = $"Seat Price:  { seatPrices[row,col].ToString("c")}";
        }



        /// <summary>
        /// Validate the input number for the row selected in the airplane
        /// </summary>
        /// <returns></returns>
        private bool ValidRow(ref int row)
        {
            // The row will be valid if the input is within the parameters below.
            if (int.TryParse(EntryRow.Text, out row) && row <= MAX_ROW && row >= MIN_ROW)
            {
                return true;
            }
            // Alert will display if the integer is smaller or larger than the constants
            DisplayAlert("We're Sorry", $"Please enter an integer between {MIN_ROW} and {MAX_ROW} for the row.", "Close");
            return false;
        }

        /// <summary>
        /// Validate the input number for the column selected in the airplane
        /// </summary>
        /// <returns></returns>
        private bool ValidColumn(ref int col)
        {
            // The column will be valid if the input is within the parameters below.
            if (int.TryParse(EntryColumn.Text, out col) && col <= MAX_COL && col >= MIN_COL)
            {
                return true;
            }
            // Alert will display if the integer is smaller or larger than the constants
            DisplayAlert("We're Sorry", $"Please enter an integer between {MIN_COL} and {MAX_COL} for the column.", "Close");
                return false;
        }

        /// <summary>
        /// Display the max revenue from the seats selectedis they all sell out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMaxRevenue_Clicked(object sender, EventArgs e)
        {
            // For loop to grab each seat price from every row and column to add them up to a total
            decimal total = 0;
            for (int i = 0; i <= MAX_ROW; i++)
            {
                for (int j = 0; j <= MAX_COL; j++)
                {
                    total += seatPrices[i, j];
                }
            }

            // Display the total amount of max revenue
            DisplayAlert("Total $Money$", $"Total Revenue: {total.ToString("c")}", "Close:");

        }
    }
}
