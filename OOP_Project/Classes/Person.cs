using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace OOP_Project.Classes
{
    public class Person : ObservableObject
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Double Age { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string middleName, string lastName, DateTime birthDate, string address)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;  
            Address = address;
        }

    }
}
