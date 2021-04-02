using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Plant_Inheritance
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        /// <summary>
        /// tempPlant property is to store the details of the selected plant
        /// </summary>
        public Plant tempPlant { get; set; }
        /// <summary>
        /// Start the application
        /// </summary>
        public PlantDetailsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Use polymorphism by knowing which is the parent and which message to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            // Display a message of what the plant smells like
            MessageBox.Show(tempPlant.Sniff());
        }
        

        /// <summary>
        /// Button to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            // Close window
            this.Close();
        }

        /// <summary>
        /// Replace the labels with the user input from the plant, env, and type
        /// </summary>
        /// <param name="plant"></param>
        public void UpdatePlant(Plant plant)
        {
            // Replace the labels with user input data
            LblPlantName.Content = plant.Name;
            LblPlantEnvironment.Content = plant.Environment;
            LblPlantType.Content = plant.Type;
        }
    }
}
