using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Inheritance
{
    /// <summary>
    /// Tree inherits plant properties
    /// </summary>
    public class Tree : Plant
    {
        // ctor tab tab is a quick constructor method
        /// <summary>
        /// overloaded method for tree
        /// </summary>
        /// <param name="name"></param>
        /// <param name="env"></param>
        /// <param name="type"></param>
        public Tree(string name, string env, string type) : base(name,env,type)
        {

        }
        /// <summary>
        /// set branch property value of a string
        /// </summary>
        public string BranchType { get; set; }

        /// <summary>
        /// method to return tree details when selected
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            return "Trees smell sappy.";
        }
    }
}
