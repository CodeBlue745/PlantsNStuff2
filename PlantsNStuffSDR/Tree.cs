using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {

        }
        public string BranchType { get; set;}
    }
}
