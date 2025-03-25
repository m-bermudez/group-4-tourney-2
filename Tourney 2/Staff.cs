using System;

namespace Tourney_2
{
public class Staff : Person
    {
        public string Position {get; set;}
        public string Department {get; set;}

        public Staff(string name, string email, string id, string position, string department) : base(name, email, id)
        {
            Position = position;
            Department = department;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My name is {Name} and my email is {Email}. Here is my school ID {ID}. My position is {Position} and I will work in {Department}.");
        }
    }
}