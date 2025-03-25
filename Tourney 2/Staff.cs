using System;

namespace Tourney_2
{
public class Staff : Person
    {
        public string _name;
        public string _email;
        public string _id;

        public string _position {get; set;}
        public string _department {get; set;}

        public Staff(string name, string email,  id, string position, string department) : base(name, email, id)
        {
            _position = position;
            _department = department;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My name is {_name} and my email is {_email}. Here is my school ID {_id}. My position is {_position} and I will work in {_department}.");
        }
    }
}