using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Inheritance
{
    /// <summary>
    /// Flower inherit's plant properties
    /// </summary>
    class Flower : Plant
    {
        /// <summary>
        /// overloaded method for Flower
        /// </summary>
        /// <param name="name"></param>
        /// <param name="env"></param>
        /// <param name="type"></param>
        public Flower(string name, string env, string type) : base(name,env,type)
        {

        }
        /// <summary>
        /// Set Petal property
        /// </summary>
        public string Petal { get; set; }
        /// <summary>
        /// method to return when sniff is selected in details
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {

            return "Roses really smell like poo-poo-oo";
        }
    }
}
