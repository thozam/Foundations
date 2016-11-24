//Assignment #6

using System;
namespace ConsoleApplication1
{
    public struct Pet // defines a structure. The public struct Pet
    {
        public string Name; // Defines the field Name of type string in the Pet structure
        public string TypeOfPet;// Defines the field TypeOfPet of type string in the Pet structure
    }
    class Program
    {
        static void Main()
        {
            var numberOfPets = 0; // Declares and initializes the variable numberOfPets
            var pets = new Pet[10]; // Declares and initializes an array of the struct Pet with a length of 10
            while (true) // An infinite loop to let the user keep on going with the program
            {
                Console.Write("A)dd D)elete L)ist pets:"); // Writes to the consol window
                var choice = Console.ReadLine(); // Stores the user input to the variable choice
                switch (choice) // A switch executes code based on user input
                {
                    case "A": // If user input is "A" execute the code within the braces below
                    case "a": // just to make it non-sensitive to upper or lower case
                        {
                            Console.Write("Name :"); // Writes to the consol window
                            var name = Console.ReadLine(); // Declares the variable name and stores the user input into it
                            Console.Write("Type of pet :"); // Writes to the consol window
                            var typeOfPet = Console.ReadLine(); // Declares the variable typeOfPet and stores the user input into it
                            pets[numberOfPets].Name = name; // Always adds the pets name at the end of the array
                            pets[numberOfPets].TypeOfPet = typeOfPet; //Always adds the type of the pet at the end of the array
                            numberOfPets++; // We have one more pet in the array
                            break; // Exits the switch statement (and continues with the infinite loop)
                        }
                    case "D": // If user input is "D" execute the code within the braces below
                    case "d": // just to make it non-sensitive to upper or lower case
                        {
                            if (numberOfPets == 0) // If numberOfPets equals 0, execute the code within the braces below
                            {
                                Console.WriteLine("No pets"); // Writes to the consol window
                                break; // Exits the switch statement (and continues with the infinite loop)
                            }
                            for (var index = 0; index < numberOfPets; index++) //Makes sure we execute the code below one time for each pet
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); // Creates a nice table, one line for each pet. Numbered 1, 2, 3 etc
                            }
                            Console.Write("Which pet to remove (1-{0})", numberOfPets); // Writes to the consol window (with the right range)
                            var petNumberToDelete = Console.ReadLine(); // Declares the variable petNumberToDelete and stores the user input into it
                            var indexToDelete = int.Parse(petNumberToDelete); // Declares the variable indexToDelete and casts the user input into it as an int
                            for (var index = indexToDelete - 1; index < numberOfPets; index++) // Squish the array from index to the end
                            {
                                pets[index] = pets[index + 1]; // Just copy the pet from the next index into the current index
                            }
                            numberOfPets--; // We have one less pet
                            break; // Exits the switch statement (and continues with the infinite loop)
                        }
                    case "L": // If user input is "L" execute the code within the braces below
                    case "l": // just to make it non-sensitive to upper or lower case
                        {
                            if (numberOfPets == 0) // If numberOfPets equals 0, execute the code within the braces below
                            {
                                Console.WriteLine("No pets"); // Writes to the consol window
                            }
                            for (int index = 0; index < numberOfPets; index++) //Makes sure we execute the code below one time for each pet
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); // Creates a nice table, one line for each pet. Numbered 1, 2, 3 etc
                            }
                            break; // Exits the switch statement (and continues with the infinite loop)
                        }
                    default: // If user input is something different than A, D, L, a, d or l execute the code within the braces below
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); // Writes to the consol window (repeating the user input)
                            break; // Exits the switch statement (and continues with the infinite loop)
                        }
                }
            }
        }
    }
}