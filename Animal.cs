using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    //3.3 starts here
    // Create abstract class Animal
    public abstract class Animal
    {
        //Properties 
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        //Create an abstract method DoSound()
        public abstract void DoSound();
        //3.4
        //Create the Stats() method to override in subclasses
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
        // end of 3.4
        //Add a constructor
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

    //Create subclasses (Horse, Dog, Hedgehog, Worm, Bird, Wolf)
    public class Horse : Animal
    {
        // Unique property for Horse
        public string Color { get; set; }

        public Horse(string name, double weight, int age, string color)
            : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse makes a neigh sound.");
        }

        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, Color: {Color}";
        }
    }

    public class Dog : Animal
    {
        //Unique property for Dog
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed)
            : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog makes a bark sound.");
        }
        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, Breed: {Breed}";
        }
        //3.4.15
        // New method with an optional parameter
        public string NewOptionalMethod(string name = "Optional String return")
        {
            return $"New Optional method for Dog. Name: {name}";
        }
    }

    public class Hedgehog : Animal
    {
        //Unique property for Hedgehog
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes)
            : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog makes grunting and snuffling sound.");
        }

        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, NrOfSpikes: {NrOfSpikes}";
        }
    }

    public class Worm : Animal
    {
        //Unique property for Worm
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age, bool isPoisonous)
            : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm makes a gurgling sound.");
        }
        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, IsPoisonous: {IsPoisonous}";
        }
    }

    public class Bird : Animal
    {
        //Unique property for Bird
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan)
            : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird makes a chirping sound.");
        }

        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, WingSpan: {WingSpan}";
        }
    }

    public class Wolf : Animal
    {
        //Unique property for Wolf
        public double Size { get; set; }

        public Wolf(string name, double weight, int age, double size)
            : base(name, weight, age)
        {
            Size = size;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf makes a howling sound.");
        }

        //3.4.2
        public override string Stats()
        {
            return $"{base.Stats()}, Size: {Size}";
        }
    }

    //Create Pelican, Flamingo, and Swan classes which inherit from Bird
    public class Pelican : Bird
    {
        //Unique property for Pelican
        public bool GularPouch { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, bool gularpouch)
            : base(name, weight, age, wingSpan)
        {
            GularPouch = gularpouch;
        }
    }

    public class Flamingo : Bird
    {
        // Unique property for Flamingo
        public bool LeanNeck { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, bool leanneck)
            : base(name, weight, age, wingSpan)
        {
            LeanNeck =leanneck;
        }
    }

    public class Swan : Bird
    {
        //Unique property for Swan
        public double Size { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, double size)
            : base(name, weight, age, wingSpan)
        {
            Size = size;
        }
    }

    //Create IPerson interface
    public interface IPerson
    {
        void Talk();
    }

    //Create Wolfman class that inherits from Wolf and implements IPerson
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, double size)
            : base(name, weight, age, size)
        {
        }

        //Implement Talk() 
        public void Talk()
        {
            Console.WriteLine("\nInherited from Wolf and implements Iperson interface");
        }
    }
    //F: If during development we come to the conclusion that all birds need a new attribute, in which class should we put it?
    //A: Attributes which all birds needs should be added in Bird class.Thus we don't have to repeat it in every class but we get it in each class.
    //Q: If all animals need the new attribute, where would you put it?
    //A: Attributes which all animals needs should be added in Animal class.
    //3.3 ends here
}
