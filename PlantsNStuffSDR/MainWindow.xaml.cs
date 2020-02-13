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
        //This dictioanry makes all of the other dicionaaries easier to handle.
        Dictionary<string, Plant> plantdict = new Dictionary<string, Plant>();
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
            //All of the ComboBoxes
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
        /// <summary>
        /// this is the show Details button. It will show a dialog box that displays the details of each added flower, tree or shrubbery.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            //validate 1st box selection
            if (LstBoxPlants.SelectedIndex > -1)
            {
                //key string is created with information from the LstBoxPlants that was put in by the user.
                string key = LstBoxPlants.SelectedItem.ToString();
                //get value of the key string from dictionary and put out plant value from the plant class. Using "out" might be the same as setting a value.
                if (plantdict.TryGetValue(key, out Plant plant))
                {
                    //Here, we create a new PlantDetailswindow and assign it to plantDW. 
                    PlantDetailsWindow plantDW = new PlantDetailsWindow();
                    //plantDW's UpdatePlant method is called taking with it the plant value. This displays the name, environment, and type in the new window we created.
                    plantDW.UpdatePlant(plant);
                    //Here, we call the tempPlant method and get the user input and set it to the result in the window.
                    plantDW.tempPlant = plant;
                    //Here, we show the window.
                    plantDW.Show();
                }
                else
                {
                    //This messagebox comes up if something goes amiss in the new window.
                    MessageBox.Show("Unable to find that new species");
                }
            }
            else
            {
                //This Message box displays if the dictionary won't load.
                MessageBox.Show("Please select a plant from the list box first", "Invalid Input");
            }
        }
        /// <summary>
        /// This method adds userinput to the List box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            //Validate user input in the Textbox and values in the comboBoxes.
            if (TxtBoxName.Text != "" &&
                CbEnvironment.SelectedIndex > -1 &&
                CbType.SelectedIndex > -1)
            {
                //Assign variables to objects.
                string name = TxtBoxName.Text;
                string env = CbEnvironment.SelectedItem.ToString();
                string type = CbType.SelectedItem.ToString();
                //Add whatever the user types in to the listbox.
                LstBoxPlants.Items.Add(TxtBoxName.Text);
                // a Swtich case is just a condensed if else statement.
                switch (type)
                {
                    //We get Flower from the type Combobox and assign  takes a name, env and type.
                    case "Flower":
                        Flower flower = new Flower(name, env, type);
                        //We add the name and flower to the plant dictioanry
                        plantdict.Add(name, flower);
                        //break the case when finished.
                        break;
                        //We do the same thing for the following cases.
                    case "Shrubbery":
                        Shrubbery shrubbery = new Shrubbery(name, env, type);
                        plantdict.Add(name, shrubbery);
                        break;
                    case "Tree":
                        Tree tree = new Tree(name, env, type);
                        plantdict.Add(name, tree);
                        break;
                    //The default throws if, somehow, we get another value in the combobox.
                    default:
                        MessageBox.Show("The type was not found in the database");
                        //Break the default.
                        break;
                }
                //This counts the items indexed in the listbox and assigns it to SelectedIndex method. We use -1 because if you have six objects in a list, it will include the zeroeth count and onward, so a total of 7. We need 7-1, or 6 in that instance.
                LstBoxPlants.SelectedIndex = LstBoxPlants.Items.Count - 1;
            }
            else
            {
                //Throw this if an invalid error was encountered.
                MessageBox.Show("Please enter a name, type, and environment", "Invalid Input");
            }
        }
    }
}