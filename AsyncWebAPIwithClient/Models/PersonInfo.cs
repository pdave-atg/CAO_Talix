using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsyncWebAPIwithClient.Models
{
    public class PersonInfo
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }


    public class PersonData : List<PersonInfo>
    {
        public PersonData()
        {
            Add(new PersonInfo()
            {
                PersonId = 1,
                PersonName = "MS",
                Age = 39,
                Gender = "Male",
                City = "Pune"
            });
            Add(new PersonInfo()
            {
                PersonId = 2,
                PersonName = "LS",
                Age = 37,
                Gender = "Female",
                City = "Pune"
            });
            Add(new PersonInfo()
            {
                PersonId = 3,
                PersonName = "TS",
                Age = 12,
                Gender = "Male",
                City = "Pune"
            });
            Add(new PersonInfo()
            {
                PersonId = 4,
                PersonName = "VB",
                Age = 32,
                Gender = "Female",
                City = "Pune"
            });
            Add(new PersonInfo()
            {
                PersonId = 5,
                PersonName = "PB",
                Age = 33,
                Gender = "Male",
                City = "Pune"
            });
            Add(new PersonInfo()
            {
                PersonId = 6,
                PersonName = "AB",
                Age = 5,
                Gender = "Male",
                City = "Pune"
            });
        }
    }
}