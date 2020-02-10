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
    /// We will start by inheriting Plant into Shrubbery's class.
    /// </summary>
    public class Shrubbery : Plant
    {
        /// <summary>
        /// Then, we will bring in all of the plant attributes.
        /// </summary>
        public Shrubbery() : base("", "", "")
        {}
        /// <summary>
        /// BushTyps is called with get and set because we will get and set some more attributes to the Shrubbery in class next week.
        /// </summary>
        public string BushType { get; set; }
        /// <summary>
        /// The Sniff method puts Smells like Dirt into the reaction variable. That variable is returned every time the method is called. I will use this method and assign it to a click event for the tree image in the future, in class.
        /// </summary>
        public string Sniff()
        {
            //Reaction variable is created and assigned.
            string reaction = "Smells like Dirt";
            //Reaction is returned when the method is called.
            return reaction;
        }
    }
}