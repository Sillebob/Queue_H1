using System;
using System.Collections.Generic;
using System.Text;

namespace Køen_H1
{
    class Svømmer
    {
        private string firstName;
        private int age;

        public Svømmer()
        { }
        public Svømmer(string firstName, int age = 0)
        {
            this.firstName = firstName;
            this.age = age;
        }

        public String FirstName { get { return firstName; } set { firstName = value; } }
        public int Age { get { return age; } set { age = value; } }

    }


}
