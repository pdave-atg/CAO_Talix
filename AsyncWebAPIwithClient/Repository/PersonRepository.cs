using AsyncWebAPIwithClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsyncWebAPIwithClient.Repository
{
    public class PersonRepository : IPersonRepository<PersonInfo,int>
    {
        DataAccess objds;
        public PersonRepository()
        {
            objds = new DataAccess();
        }
        public IEnumerable<PersonInfo> Add(PersonInfo obj)
        {
            return objds.Add(obj);
        }

        public IEnumerable<PersonInfo> Delete(int id)
        {
            return objds.Delete(id);
        }

        public IEnumerable<PersonInfo> Get()
        {
            return objds.Get();
        }

        public PersonInfo Get(int id)
        {
            return objds.Get(id);
        }

        public IEnumerable<PersonInfo> Update(int id, PersonInfo obj)
        {
            return objds.Update(id, obj);
        }
    }
}