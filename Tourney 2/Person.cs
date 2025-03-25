using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_2
{
    public class Person
    {
        public string _name {get; set;}
        public string _email {get; set;}
        public string _id {get; set;}

        public Person(string name, string email, string id)
        {
            _name = name;
            _email = email;
            _id = id;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Email: {_email}, ID: {_id}");
        }
    }
}
