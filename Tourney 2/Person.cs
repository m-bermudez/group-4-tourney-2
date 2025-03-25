using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_2
{
    public class Person
    {
        protected string _name;
        protected string _email;
        protected int _id;

        public Person(string name, string email, int id)
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
