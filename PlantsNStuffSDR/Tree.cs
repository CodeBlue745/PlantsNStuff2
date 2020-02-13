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
        public Tree(string name, string env, string type) : base (name, env, type)
        {}
        /// <summary>
        /// BranchType is a method in the Tree class that gets and sets things.
        /// </summary>
        public string BranchType { get; set;}
        /// <summary>
        /// The Sniff method tells whatever calls the method that the tree smells like bark.
        /// </summary>
        public override string Sniff()
        {
            //Reaction variable is created and assigned.
            return "Trees hava a sharp, clean smell.";
            //Reaction is returned when the method is called.
        }
    }
}