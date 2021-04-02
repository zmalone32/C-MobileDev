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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plant_Inheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 
        Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();
        // Dictionaries to hold users inputs
        //Dictionary<string, Tree> TreeDict = new Dictionary<string, Tree>();
        //Dictionary<string, Shrub> ShrubDict = new Dictionary<string, Shrub>();
        //Dictionary<string, Flower> FlowerDict = new Dictionary<string, Flower>();

        public MainWindow()
        {
            InitializeComponent();
            // Load all the combo box values
            LoadComboBoxes();
        }

        /// <summary>
        /// Loads in the strings of what the environments and types are
        /// </summary>
        private void LoadComboBoxes()
        {
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Tropical");
            CbType.Items.Add("Flower");
            CbType.Items.Add("Shrub");
            CbType.Items.Add("Tree");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            // Validate list box selection
            if (LstBoxPlants.SelectedIndex > -1)
            {
                string key = LstBoxPlants.SelectedItem.ToString();
                // Get value from dictionary
                if (plantDict.TryGetValue(key, out Plant plant))
                {
                    PlantDetailsWindow plantDW = new PlantDetailsWindow();
                    plantDW.UpdatePlant(plant);
                    plantDW.tempPlant = plant;
                    plantDW.Show();
                    // This is just for a simple message box
                    // MessageBox.Show($"{plant.Type} Name: {plant.Name}\n\n" + $"Environment: {plant.Environment}\n\n" + $"Type: {plant.Type}");
                
                }
                else
                {
                    // 
                    MessageBox.Show("Could not find object in the database.");
                }
                // Display values from the dictionary
            }
            else
            {
                MessageBox.Show("Please select a plant from the list box first","Invalid Input");
            }

            

        }

        /// <summary>
        /// Add's a plant, env, and type to the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            // Validate user input
            if (TbName.Text != "" && CbEnvironment.SelectedIndex > -1 && CbType.SelectedIndex > -1)
            {
                string name = TbName.Text;
                string env = CbEnvironment.SelectedItem.ToString();
                string type = CbType.SelectedItem.ToString();
                // Add the item to the list box that was typed out in the txt box
                LstBoxPlants.Items.Add(name);

                switch (type)
                {
                    case "Flower":
                        Flower flower = new Flower(name, env, type);
                        plantDict.Add(name, flower);
                        break;
                    case "Shrub":
                        Shrub shrub = new Shrub(name, env, type);
                        plantDict.Add(name, shrub);
                        break;
                    case "Tree":
                        Tree tree = new Tree(name, env, type);
                        plantDict.Add(name, tree);
                        break;

                    default:
                        MessageBox.Show("The type was not found in the database");
                        break;
                }
                // Select the item that was just added
                LstBoxPlants.SelectedIndex = LstBoxPlants.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Please enter a name, type, and environment", "Invalid Input");
            }
        }
    }
}
