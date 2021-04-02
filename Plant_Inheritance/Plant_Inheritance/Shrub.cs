using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Inheritance
{
    /// <summary>
    /// Shrub inherits plant properties
    /// </summary>
    class Shrub : Plant
    {
        /// <summary>
        /// overloaded method for shrub
        /// </summary>
        /// <param name="name"></param>
        /// <param name="env"></param>
        /// <param name="type"></param>
        public Shrub(string name, string env, string type) : base(name,env,type)
        {

        }
        /// <summary>
        /// set object to return as an int
        /// </summary>
        public int ShrubHeight { get; set; }

        /// <summary>
        /// method to return when details is selected
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            return "Shrubs smell like shrubbish.";
        }
    }
}
