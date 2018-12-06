using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Classes;

namespace OOP_Project.Module
{
    public class PersonModule
    {
        public ObservableCollection<Person> CustomerList { get; set; } = new ObservableCollection<Person>();
        public Person SelectedPerson { get; set; }

        public PersonModule()
        {
            GenerateCustomer();
        }

        public void GenerateCustomer()
        {
            CustomerList.Add(new Person("Mark","I.","Ocampo", new DateTime(1997,6,18),"Bukid"));
        }
    }
}
