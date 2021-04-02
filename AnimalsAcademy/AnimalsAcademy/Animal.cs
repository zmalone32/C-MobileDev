using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAcademy
{
    public abstract class Animal
    {
        private string _skinType;
        private string _foodType;
        
        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }


        public string SkinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }


        /// <summary>
        /// Constructor method for the Animal class
        /// </summary>
        /// <param name="stype"></param>
        /// <param name="ftype"></param>
        public Animal(string stype, string ftype)
        {
            SkinType = stype;
            FoodType = ftype;
        }
        /// <summary>
        /// Returns the string for Eat
        /// </summary>
        /// <returns></returns>
        public string Eat()
        {
            return "chomp chomp";
        }
        /// <summary>
        /// Returns the string for reproduce
        /// </summary>
        /// <returns></returns>
        public string Reproduce()
        {
            return "have offspring";
        }
        /// <summary>
        /// Returns the built in virtual string for Move
        /// </summary>
        /// <returns></returns>
        public virtual string Move()
        {
            return "hippity hop";
        }
        /// <summary>
        /// Abstract method for Unique
        /// </summary>
        /// <returns></returns>
        public abstract string Unique();



    }
}
