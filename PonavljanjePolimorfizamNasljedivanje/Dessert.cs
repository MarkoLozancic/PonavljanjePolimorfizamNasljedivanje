using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    
        class Dessert
        {
            private string name;
            private double weight;
            private int calories;

            public Dessert(string name, double weight, int calories)
            {
                this.Name = name;
                this.Weight = weight;
                this.Calories = calories;
            }

            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
            public int Calories { get => calories; set => calories = value; }


            public override string ToString()
            {
                return name + ":  weight - " + weight + "g, calories - " + calories + "kcal";
            }

            public string getDessertType()
            {
                return "dessert";
            }
        }
    
}
