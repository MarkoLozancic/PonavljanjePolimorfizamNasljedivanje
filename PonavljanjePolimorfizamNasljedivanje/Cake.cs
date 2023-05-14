using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    class Cake : Dessert
    {
        private bool containsGluten;
        private string cakeType;

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.containsGluten = containsGluten;
            this.cakeType = cakeType;
        }


        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public override string ToString()
        {
            return Name + ":  weight - " + Weight + "g, calories - " + Calories
                + "kcal, contains gluten - " + ContainsGluten + ", Cake type - " + CakeType;
        }

        public string GetDessertType()
        {
            return cakeType + "Cake";
        }
    }
}
