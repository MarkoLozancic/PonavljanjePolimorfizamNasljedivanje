using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    class Person
    {
        String name;
        String surname;
        int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return "Name - " + name + ", Surname - " + surname + ", Age - " + age;
        }

        public bool equals(string name1, string surname1, int age1, string name2, string surname2, int age2)
        {
            if (name1 == name2 && surname1 == surname2 && age1 == age2)
                return true;
            else
                return false;

        }
    }
}
