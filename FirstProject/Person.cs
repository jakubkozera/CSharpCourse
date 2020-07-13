using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }
    }
}
