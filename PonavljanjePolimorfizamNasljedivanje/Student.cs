using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PonavljanjeDessert
{
   class Student:Person
    {
        private String studentId;
        private short academicYear;

        public Student(string name, string surname, int age, String studentId, short academicYear) : base(name, surname, age)
        {
            this.studentId = studentId;
            this.academicYear = academicYear;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override string ToString()
        {
            return "Name - " + Name + ", Surname - " + Surname + ", Age - " + Age+ ", Student ID - " + studentId + ", Academic Year - " + academicYear + ".";
        }

       public bool equals(String studentId1,String studentId2)
        {
            

            if (studentId1==studentId2)
                return true;
            else
                return false;

        }
      

    }
}
