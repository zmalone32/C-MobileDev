using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAcademy
{
    /// <summary>
    /// Chicken inherits animal properties
    /// </summary>
    public class Chicken : Animal
    {
        /// <summary>
        /// Chicken class that displays the skin type and the food type
        /// </summary>
        public Chicken():base("Feathery Wings","Worms in the Ground & leftovers")
        {
            
        }
        /// <summary>
        /// reutrn the string on how the chicken moves
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            return "Waddles and flaps out of the hands who try to catch them";
        }
        /// <summary>
        /// return unique string about chicken
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            return "Great on the farm and better on the dinner table";
        }
    }
}
