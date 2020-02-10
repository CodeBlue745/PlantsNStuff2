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
    /// This public class inherits the Plant class.
    /// </summary>
    public class Tree : Plant
    {   
        /// <summary>
        /// We need a name, environment and type or name, env and type variables.
        /// The base class represents everything from the Plant class.
        /// </summary>
        public Tree() : base("","","")
        {}
        public string BranchType { get; set;}
        /// <summary>
        /// The Sniff method tells whatever calls the method that the tree smells like bark.
        /// </summary>
        public string Sniff()
        {
            //Here is where the raction variable is assigned. It is createed as a string.
            string reaction = "Smells like Bark";
            //This is where the variable is returned when Sniff(); is called.
            return reaction;
        }
    }
}