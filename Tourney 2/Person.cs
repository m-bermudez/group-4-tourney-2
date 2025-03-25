using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_2
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}, ID: {ID}");
        }
    }
}
