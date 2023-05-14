using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    class IceCream : Dessert
    {
        private string flavour;
        private string color;

        public IceCream(string name, double weight, int calories, string flavour, string color) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }

        

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }


        public override string ToString()
        {
            return Name + ":  weight - " + Weight + "g, calories - " + Calories
                + "kcal, Flavour - " + Flavour + ", Color - " + Color;
        }
        public string GetDessertType()
        {
            return "IceCream";
        }
    }
   
}

