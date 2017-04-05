using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsyncWebAPIwithClient.Models
{
    public class DataAccess
    {
        public static PersonData Persons;

        public DataAccess()
        {
            Persons = new PersonData();
        }

        public PersonData Get()
        {
            return Persons;
        }

        public PersonInfo Get(int id)
        {
            return Persons.Find(p => p.PersonId == id);
        }

        public PersonData Add(PersonInfo p)
        {
            Persons.Add(p);
            return Persons;
        }

        public PersonData Update(int id, PersonInfo p)
        {
            var per = Persons.Find(px => px.PersonId == id);
            if (per != null)
            {
                Persons.Remove(per);
                Persons.Add(p);
            }
            return Persons;
        }

        public PersonData Delete(int id)
        {
            var per = Persons.Find(px => px.PersonId == id);
            if (per != null)
            {
                Persons.Remove(per);
            }
            return Persons;
        }
    }
}