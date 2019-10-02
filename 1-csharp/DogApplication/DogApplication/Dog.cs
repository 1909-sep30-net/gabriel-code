using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        // access modifiers

        // fields

        //public string name;

        //public int age;

        public Dog(string name, int age)
        {
            if (name == null)
            {
                throw new ArgumentNullException(name);
            }
            this.name = name;

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.age = age;
        }

        /*
         * public int Age{get; set;}
         * 
         * 
         */

        private string name;

        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

    }
}
