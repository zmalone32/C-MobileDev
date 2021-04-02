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

namespace AnimalsAcademy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Start the app and check the first radio button
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            RbDog.IsChecked = true;
        }

        // Create variables for the animals
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal chicken = new Chicken();

        /// <summary>
        /// Skin event which clasifies the type with the correct string 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSkin_Click(object sender, RoutedEventArgs e)
        {
            // statements to check if an radio button is checked, display the out put of the specified variable and the string of skin type
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.SkinType;
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.SkinType;
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.SkinType;
            }
        }
        /// <summary>
        /// Food event that clasifies the type with the right string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFood_Click(object sender, RoutedEventArgs e)
        {
            // statements to check if an radio button is checked, display the out put of the specified variable and the string of food type
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.FoodType;
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.FoodType;
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.FoodType;
            }
        }
        /// <summary>
        /// Eat event which triggers the string to populate from the variable selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            // statements to check if an radio button is checked, display the out put of the specified variable and the string of Eat method
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.Eat();
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.Eat();
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.Eat();
            }
        }
        /// <summary>
        /// Move event which triggers the string to populate from the variable selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            // statements to check if an radio button is checked, display the out put of the specified variable and the string of Move method
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.Move();
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.Move();
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.Move();
            }
        }
        /// <summary>
        /// Reproduce event which triggers the string to populate from the variable selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReproduce_Click(object sender, RoutedEventArgs e)
        {
            // statements to check if an radio button is checked, display the out put of the specified variable and the string of Reproduce method
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.Reproduce();
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.Reproduce();
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.Reproduce();
            }
        }
        /// <summary>
        /// Unique event which triggers the string to populate from the variable selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUnique_Click(object sender, RoutedEventArgs e)
        {
            // // statements to check if an radio button is checked, display the out put of the specified variable and the string of Unique method
            if ((bool)RbDog.IsChecked)
            {
                LblOutput.Content = dog.Unique();
            }
            else if ((bool)RbCat.IsChecked)
            {
                LblOutput.Content = cat.Unique();
            }
            else if ((bool)RbChicken.IsChecked)
            {
                LblOutput.Content = chicken.Unique();
            }
        }
        /// <summary>
        /// pull image from source if selected and clean output when not selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbDog_Checked(object sender, RoutedEventArgs e)
        {
            imgAnimal.Source = new BitmapImage(new Uri("/Resources/dog.jpg", UriKind.Relative));
            LblOutput.Content = "";
        }
        /// <summary>
        /// pull image from source if selected and clean output when not selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbCat_Checked(object sender, RoutedEventArgs e)
        {
            imgAnimal.Source = new BitmapImage(new Uri("/Resources/cat.jpeg", UriKind.Relative));
            LblOutput.Content = "";

        }
        /// <summary>
        /// pull image from source if selected and clean output when not selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbChicken_Checked(object sender, RoutedEventArgs e)
        {
            imgAnimal.Source = new BitmapImage(new Uri("/Resources/chicken.jpg", UriKind.Relative));
            LblOutput.Content = "";

        }
    }
}
