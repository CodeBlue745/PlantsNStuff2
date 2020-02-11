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
        Dictionary<string, Tree> TreeDict = new Dictionary<string, Tree>();
        Dictionary<string, Shrubbery> ShrubDict = new Dictionary<string, Shrubbery>();
        Dictionary<string, Flower> FlowerDict = new Dictionary<string, Flower>();
        /// <summary>
        /// This MainWindow displays all of my xaml elements located in the MainWindow.xaml file. 
        /// </summary>
        public MainWindow()
        {
            //this is where the entire app is called.
            InitializeComponent();
            //This calls the Load Combo Boxes method.
            LoadComboBoxes();
            //This is where I call the LoadPlants method.
            LoadPlants();
        }
        /// <summary>
        /// This method adds words to each combo box.
        /// </summary>
        private void LoadComboBoxes()
        {
            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Tropical");
            CbType.Items.Add("Flower");
            CbType.Items.Add("Shrubbery");
            CbType.Items.Add("Tree");
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //validate 1st box selection
            if (LstBoxPlants.SelectedIndex > -1)
            {
                string key = LstBoxPlants.SelectedItem.ToString();
                //get value from dictionary
                if (FlowerDict.TryGetValue(key, out Flower flower))
                {
                    MessageBox.Show($"Flower Name: {flower.Name}\n\n" +
                        $"Environment: {flower.Environment}\n\n" +
                        $"Type: {flower.Type}");

                }
                else if (TreeDict.TryGetValue(key, out Tree tree))
                {

                }
                else if (ShrubDict.TryGetValue(key, out Shrubbery shrubby))
                {

                }
                else
                {
                    MessageBox.Show("Unable to find that new species");
                }
                //display valuse from dictioanry
            }
            else
            {
                MessageBox.Show("Please select a plant from the list box first", "Invalid Input");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Validate user input
            if (TxtBoxName.Text != "" &&
                CbEnvironment.SelectedIndex > -1 &&
                CbType.SelectedIndex > -1)
            {
                string name = TxtBoxName.Text;
                string env = CbEnvironment.SelectedItem.ToString();
                string type = CbType.SelectedItem.ToString();
                LstBoxPlants.Items.Add(TxtBoxName.Text);

                switch (type)
                {
                    case "Flower":
                        Flower flower = new Flower(name, env, type);
                        FlowerDict.Add(name, flower);
                        break;
                    case "Shrubbery":
                        Shrubbery shrubbery = new Shrubbery(name, env, type);
                        ShrubDict.Add(name, shrubbery);
                        break;
                    case "Tree":
                        Tree tree = new Tree(name, env, type);
                        TreeDict.Add(name, tree);
                        break;

                    default:
                        MessageBox.Show("The type was not found in the database");
                        break;
                }
                LstBoxPlants.SelectedIndex = LstBoxPlants.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Please enter a name, type, and environment", "Invalid Input");

            }
        }
    }
}