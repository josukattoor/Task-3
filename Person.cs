using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
  public  class Person
    {
        // Private fields
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Public properties with using get and set
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age should be greater than 0");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name should contain minimum 2 and maximum 10 characters");
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must contain minimum 3 and maximum 15 characters.");
                }
                lName = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be greater than 0");
                }
                height = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight should be greater than 0");
                }
                weight = value;
            }
        }

    }
  public class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            // Use the Age property to set person's age 
            person.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            // Create and return a new Person object with specified values
            var person = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return person;
        }
        public void SetHeight(Person person, double height)
        {
            // Use the Height property to set the person's height
            person.Height = height;
        }

        public void SetWeight(Person person, double weight)
        {
            // Use the Weight property to set the person's weight
            person.Weight = weight;
        }

        public void SetFname(Person person, string fname)
        {
            // Use the FName property to set the person's fname
            person.FName = fname;
        }
        public void SetLname(Person person, string lname)
        {
            // Use the LName property to set the person's lname
            person.LName = lname;
        }
    }
}
