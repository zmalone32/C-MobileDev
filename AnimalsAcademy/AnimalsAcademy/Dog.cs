using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAcademy
{
    /// <summary>
    /// Dog inherits animal properties
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Dog class that displays the skin type and the food type
        /// </summary>
        public Dog() :base("Fluffy Long Hair", "My Homework")
        {

        }
        /// <summary>
        /// reutrn the string on how the dog moves
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            return "Trotting through the yard";
        }

        /// <summary>
        /// return unique string about dog
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            return "Man's Best Friend";
        }
    }
}
