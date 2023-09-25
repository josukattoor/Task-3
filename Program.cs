using System;


namespace Task_3
{


    class Program
    {
        static void Main(string[] args)
        {
            // 3.1 starts here
            //try
            //{
            // Task 3.1 code should be commented before checking 3.2

            //Create instance of person class

            //Person person = new Person();

            //Assign values to each property
            //person.Age = 1;
            //person.Height = 100;
            //person.Weight = 100;
            //person.LName = "Jossy";
            //person.FName = "Sebastian";


            //    var handler = new PersonHandler();

            //    // Create person1 with correct values
            //    var person1 = handler.CreatePerson(37, "Jossy", "Sebastian", 180, 82);

            //    // Set age for person1
            //    handler.SetAge(person1, 35);

            //    // Set height for person1
            //    handler.SetHeight(person1, 154);

            //    // Set fname for person1
            //    handler.SetFname(person1, "Ian");

            //    // Set lname for person1
            //    handler.SetLname(person1, "Kattoor");

            //    // Set weight for person1
            //    handler.SetWeight(person1, 26);

            //    // Create and validate person1 with wrong values
            //    var person2 = handler.CreatePerson(-1, "h", "er", -2, -3);

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception: " + ex.Message);
            //}
            //3.1 ends here
            //3.2 starts here
            //{

            // Create a list of UserErrors and populate it with instances of NumericInputError and TextInputError.
            // List<UserError> errors = new List<UserError>
            //{
            //    new NumericInputError(),
            //    new TextInputError()
            //};

            //// Print all UserErrors UEMessage() through a foreach loop.
            //foreach (var error in errors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}

            //// Create three custom classes with custom UEMessage() 

            //var customError1 = new CustomError1();

            //var customError2 = new CustomError2();

            //var customError3 = new CustomError3();

            //// Test
            //Console.WriteLine(customError1.UEMessage());
            //Console.WriteLine(customError2.UEMessage());
            //Console.WriteLine(customError3.UEMessage());
            //}
            //3.2 ends here
            //3.4
            //Create a list of Animals 
            List<Animal> animals = new List<Animal>();

            //Create some animals in list
            animals.Add(new Horse("Bay Horse", 1000, 1, "Bay"));
            animals.Add(new Dog("Jacky", 25, 2, "German Shepherd"));
            animals.Add(new Hedgehog("Alien", 10, 3, 5000));
            animals.Add(new Worm("Small worm", 0.001, 4, true));
            animals.Add(new Pelican("Pelican Bird", 10, 5, 1, true));
            animals.Add(new Wolf("Wolf animal", 45, 6, 500.50));
            animals.Add(new Wolfman("Wolf person", 55, 7, 800.50));


            //Print list of animals
            Console.WriteLine("List of animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            //Call Animals DoSound() method 
            Console.WriteLine("\nAnimal sounds:");
            foreach (var animal in animals)
            {
                animal.DoSound();
            }

            //Check if an animal is also of type IPerson and call its Talk() method
            foreach (var animal in animals)
            {
                if (animal is IPerson person)
                {
                    person.Talk();
                }
            }

            //Create list for dogs
            List<Dog> dogs = new List<Dog>();

            // F: Try to add a horse to the list of dogs. Why doesn't it work?
            //dogs.Add(new Horse("Horse1", 1500, 10, "Chestnut"));
            // This will not work because both classes are different. To the list of dogs classes only new dog can be added. To add a new horse to list of dogs horse should be subclass of dog (like we did in the animal class and added different animals to the same list)

            //F: What type must the list be for all classes to be stored together?
            // Create a list of animals as we did in line 12.

            //Print all Animals Stats()
            Console.WriteLine("\nAnimal stats:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            // Test and see how it works.

            //F: Prints the stats method written in each subclass of animal class along with unique property of each subclass. 
            //Stats in Animal class is overriden in each subclass.
            //Prints the stats method for each subclass as follows.:
            //Animal stats:
            //Name: Bay Horse, Weight: 1000, Age: 1, Color: Bay
            //Name: Jacky, Weight: 25, Age: 2, Breed: German Shepherd
            //Name: Alien, Weight: 10, Age: 3, NrOfSpikes: 5000
            //Name: Small worm, Weight: 0,001, Age: 4, IsPoisonous: True
            //Name: Pelican Bird, Weight: 10, Age: 5, WingSpan: 1
            //Name: Wolf animal, Weight: 45, Age: 6, Size: 500,5
            //Print the Stats() method only for all dogs
            Console.WriteLine("\nDog stats:");
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Stats());
                }
            }

            // Do you access that method from the Animals list?
            //F:Cannot access NewOptionalMethod created in dog class because it is specific to dog class.
            //If it was specified in the base class then it could have been accessible from animal list and all classes could have used it.
            //Find a way to print your new method for dog through a foreach on Animals
            Console.WriteLine("\nNew Optional Method from Dog class:");
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.NewOptionalMethod("Bulldog"));
                }
            }
            //3.4 ends here
        }
    }
}