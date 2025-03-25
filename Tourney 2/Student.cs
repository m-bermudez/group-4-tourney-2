using System;

namespace Tourney_2
{
public class Student : Person
    {
        private string _name;
        private string _email;
        private int _id;

        private string _major;
        private int _gradYear;

        public Student(string name, string email, int id, string major, int gradYear) : base(name, email, id)
        {
            _major = major;
            _gradYear = gradYear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My name is {_name} and my email is {_email}. Here is my school school ID {_id}. My major is {_major} and I will graduate in {_gradYear}.");
        }
    }
}