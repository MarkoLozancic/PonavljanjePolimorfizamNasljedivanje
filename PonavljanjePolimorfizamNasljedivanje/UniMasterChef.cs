using PonavljanjeDessert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjePolimorfizamNasljedivanje
{
	internal class UniMasterChef
	{
		private CompetitionEntry[] entries;

		
		private int idx = 0;

		public UniMasterChef(int noOfEntries)
		{
			this.entries = new CompetitionEntry[noOfEntries];
		}

		public bool addEntry(CompetitionEntry entry)
		{
			if (idx == this.entries.Length) return false; 

			foreach (CompetitionEntry e in entries)
			{
				if (e != null && e.equals(entry))
					return false; 
			}

			entries[idx++] = entry;
			return true;
		}

		public Dessert getBestDessert()
		{
			if (idx == 0) return null;

			double max = entries[0].getRating();
			int maxIdx = 0;

			for (int i = 0; i < idx; i++)
			{
				if (entries[i].getRating() > max)
				{
					max = entries[i].getRating();
					maxIdx = i;
				}
			}

			return entries[maxIdx].getDessert();
		}

		public static Person[] getInvolvedPeople(CompetitionEntry entry)
		{

			Person[] retVal = new Person[4]; 

			int idx = 0;

			retVal[idx++] = entry.getTeacher();

			foreach (Student s in entry.getStudents())
			{
				retVal[idx++] = s;  
			}

			return retVal;
		}
	}
}
