using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAcademy
{
    /// <summary>
    /// Cat inherits animal properties
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Cat class that displays the skin type and the food type
        /// </summary>
        public Cat():base("Frisky Whiskers","Cat Nip")
        {

        }
        /// <summary>
        /// reutrn the string on how the cat moves
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            return "Leaps up in the window sill";
        }
        /// <summary>
        /// return unique string about cat
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            return "Claw your arms when they play";
        }

    }
}
