using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;




namespace ExceptionsAssignment
{
    public class Dog

    {
        private string name;
        private int age;

        public Dog (string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 2)
                {
                    this.name = value;
                }
                else
                {
                    //Invalid if name length is less than 2
                    throw new ShortNameException();
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 100)
                {
                    throw new OverAgeLimitException();
                }
                else
                {
                    this.age = value;
                }
                if (value < 0)
                {
                    throw new NegativeAgeException();
                }
                else
                {
                    this.age = value;
                }
            }
        }





    }
}
