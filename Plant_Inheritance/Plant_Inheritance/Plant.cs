using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Inheritance
{
    /// <summary>
    /// Properties stored in the strings listed below
    /// </summary>
    public abstract class Plant
    {
        /*Propfull is used here - property is a full value....
          */
        private string _name;
        private string _environment;
        private string _type;

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

        /// <summary>
        /// Abstract class for the sniff because it is the parent value and it doesn't have a base class
        /// </summary>
        /// <returns></returns>
        public abstract string Sniff();
        // Polymorphism
    }
}
