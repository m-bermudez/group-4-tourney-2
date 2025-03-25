using System;

namespace Tourney_2
{
public class Student : Person
    {
        public string _name;
        public string _email;
        public string _id;

        public string _major { get; set; }
        public int _gradYear {get; set;}

        public Student(string name, string email, string id, string major, int gradYear) : base(name, email, id)
        {
            _major = major;
            _gradYear = gradYear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My major is {_major} and I will graduate in {_gradYear}.");
        }
    }
}