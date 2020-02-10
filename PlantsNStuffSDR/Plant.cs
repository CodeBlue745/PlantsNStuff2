using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This is where the Application namespace is called.
/// </summary>
namespace PlantsNStuffSDR
{
    /// <summary>
    /// This class is inherited by all other classes and is called a public class here to desgnate that.
    /// </summary>
    public class Plant
    {
        //We will create three variables.
        //this one lists the plant's name.
        private string _name;
        //this one is used in the Plant program to assign where the plant is grown.
        private string _environment;
        //This one is used to assign a type of plant.
        private string _type;
        /// <summary>
        /// This class creates the definition for a plant which will be inherited by all of our plant types.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="env"></param>
        /// <param name="type"></param>
        public Plant(string name, string env, string type)
        {
            //name variable is assigned to be name, publicly.
            _name = name;
            //environment variable is assigned to be called env
            _environment = env;
            //type variable is assigned to be type.
            _type = type;
        }
        /// <summary>
        /// This class creates the type variable as a string and returns a value.
        /// </summary>
        public string Type
        {
            //This is where we return the type so that it can be used in the Plant class for other methods.
            get { return _type; }
            //This is where we set the type variable to a value.
            set { _type = value; }
        }
        /// <summary>
        /// This class creates the environment variable as a string and returns a value.
        /// </summary>
        public string Environment
        {
            //This is where we return the environment so that it can be used in the Plant class for other methods.
            get { return _environment; }
            //This is where we set the environment variable to a value.
            set { _environment = value; }
        }
        /// <summary>
        /// This class creates the name variable as a string and returns a value.
        /// </summary>
        public string Name 
        {
            //This is where we return the name so that it can be used in the Plant class for other methods.
            get { return _name; }
            //This is where we set the name variable to a value.
            set { _name = value; } 
        }
    }
}