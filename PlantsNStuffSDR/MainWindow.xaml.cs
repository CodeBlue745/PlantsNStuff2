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
/// <summary>
/// This is the name of my application's solution.
/// </summary>
namespace PlantsNStuffSDR
{
    //<!--In the MainWindow.xaml.cs file, create a LoadPlants method in the constructor method that loads default values in the view.-->
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This MainWindow displays all of my xaml elements located in the MainWindow.xaml file. 
        /// </summary>
        public MainWindow()
        {
            //this is where the entire app is called.
            InitializeComponent();
            //This is where I call the LoadPlants method.
            LoadPlants();
        }
        /// <summary>
        /// This Load Plants method loads a Select default value into each combobox.
        /// </summary>
        private void LoadPlants()
        {
            //This is the Environment combobox getting the Select.
            CbEnvironment.Items.Add("Select");
            //This is the CbType combobox getting the Select.
            CbType.Items.Add("Select");

            //I tried adding an if else statement that would stop a user from adding more than 20 characters to the text box, but I discovered the test box couldn't take an add function with it.
        }
    }
}