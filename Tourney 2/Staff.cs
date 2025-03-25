using System;

namespace Tourney_2
{
public class Staff : Person
    {
        private string _name;
        private string _email;
        private int _id;

        private string _position;
        private string _department;

        public Staff(string name, string email, int id, string position, string department) : base(name, email, id)
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