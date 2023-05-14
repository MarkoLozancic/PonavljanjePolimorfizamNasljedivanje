using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    internal class Teacher:Person
    {
        private String email;
        private String subject;
        private double salary;

        public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return "Name - " + Name + ", Surname - " + Surname + ", Age - " + Age + ", Email - " + Email + ", Subject - " + Subject + ", Salary - " +Salary + " .";
        }

        public bool equals(String Email1, String Email2)
        {


            if (Email1 == Email2)
                return true;
            else
                return false;

        }

        public void increaseSalary(int p)
        {
            this.salary += (salary * p)/100;
        }

        public static void IncreaseSalary(int p, Teacher a, params Teacher[] teachers)
        {
           foreach(Teacher teacher in teachers)
            { teacher.increaseSalary(p); }
            
        }

    }
}
