using System;

namespace Tourney_2
{
public class Student : Person
    {
        public string Major { get; set; }
        public int GradYear {get; set;}

        public Student(string name, string email, string id, string major, int gradYear) : base(name, email, id)
        {
            Major = major;
            GradYear = gradYear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My major is {Major} and I will graduate in {GradYear}.");
        }
    }
}