using PonavljanjeDessert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjePolimorfizamNasljedivanje
{
	internal class CompetitionEntry
	{

		private Teacher teacher;
		private Dessert dessert;
		private Student[] students;
		private int[] ratings;

		//internal, for addRating
		private int idx;

		public CompetitionEntry(Teacher teacher, Dessert dessert)
		{
			this.teacher = teacher;
			this.dessert = dessert;
			this.students = new Student[3];
			this.ratings = new int[3];
			idx = 0;
		}

		public Teacher getTeacher()
		{
			return teacher;
		}

		public Dessert getDessert()
		{
			return dessert;
		}

		public Student[] getStudents()
		{
			return students;
		}

		public int[] getRatings()
		{
			return ratings;
		}

		public bool addRating(Student student, int rating)
		{
			if (idx == 3) return false; //full

			foreach (Student s in students)
			{
				if (s != null && s.equals(student.StudentId,s.StudentId))
					return false; //already in
			}

			students[idx] = student;
			ratings[idx] = rating;
			idx++;
			return true;
		}

		public double getRating()
		{
			if (idx == 0) return 0;

			double sum = 0;
			for (int i = 0; i < idx; i++)
				sum += ratings[i];

			return sum / idx;
		}

		
	public bool equals(CompetitionEntry other)
		{
			 
			if (!teacher.equals(other.teacher.Email,teacher.Email))
				return false;
			return true;
		}
	}
}
