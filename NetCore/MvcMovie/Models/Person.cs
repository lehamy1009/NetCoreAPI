using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public Person(string personId, string fullName, string address)
        {
            PersonId = personId;
            FullName = fullName;
            Address = address;
        }

        public Person()
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"PersonId: {PersonId}, FullName: {FullName}, Address: {Address}");
        }
    }
}