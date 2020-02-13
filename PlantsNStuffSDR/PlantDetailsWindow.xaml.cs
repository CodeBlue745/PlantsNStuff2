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
//The namespace is what the application is called.
namespace PlantsNStuffSDR
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        /// <summary>
        /// The tempPlant method gets and sets things. that's all.
        /// </summary>
        public Plant tempPlant { get; set; }
        /// <summary>
        /// This method initializes the window.
        /// </summary>
        public PlantDetailsWindow()
        {
            //Initialize window.
            InitializeComponent();
        }
        /// <summary>
        /// This method will call tempPlant.Sniff and display the information in a Messagebox when the new window we will create in another class is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            //tempPlant.Sniff returns a string for the messagebox.
            MessageBox.Show(tempPlant.Sniff());
        }
        /// <summary>
        /// This Closes the entire program with one click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //Closes the program.
            Close();
        }
        /// <summary>
        /// UpdatePlant method displays the name, environment, and type of eacy plant inputted by the user.
        /// </summary>
        /// <param name="plant"></param>
        public void UpdatePlant(Plant plant)
        {
            //This is where each attribute of the plant subclass are assigned to content of a label in the window we will create in another class.
            Result1.Content = plant.Name;
            Result2.Content = plant.Environment;
            Result3.Content = plant.Type;
        }
    }
}