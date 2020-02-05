using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsNStuffSDR
{
    public class Plant
    {
        //We will create three variables.
        private int _name;
        private int _environment;
        private int _type;

        public Plant(string name, string env, string type)
        {
            _name = name;
            _environment = env;
            _type = type;
        }



        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public string Environment
        {
            get { return _environment; }
            set { _environment = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        

    }
}
