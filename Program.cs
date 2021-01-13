using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired;
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

    }
    class Program
    {

        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var dinosaurs = new List<Dinosaur>(){
              new Dinosaur(){
                  Name = "Natasha",
                   DietType = "Herbivore",
                   WhenAcquired = DateTime.Now,
                   Weight = 14250,
                   EnclosureNumber = 4,
              },
              new Dinosaur(){
                    Name = "Loki",
                   DietType = "Carnivore",
                   WhenAcquired = DateTime.Now,
                   Weight = 3000,
                   EnclosureNumber = 75,
              },
              new Dinosaur(){
                Name = "Jarvis",
                   DietType = "Herbivore",
                   WhenAcquired = DateTime.Now,
                   Weight = 6850,
                   EnclosureNumber = 83,
              },
            };

            // Welcome the user to the app
            BannerMessage("Welcome to Jurassic Park");

            // While the user hasn't chosen to Quit:
            // -- Before the loop, set the Bool to False
            var userHasChosenToQuit = false;
            // --- While the Bool is False
            while (userHasChosenToQuit == false)
            {
                // --- Show the Menu
                // Display to them the menu Options:
                Console.WriteLine();
                Console.WriteLine("Menu: ");
                Console.WriteLine("VIEW: To View a list of our dinosaurs ");
                Console.WriteLine("ADD: To Add a new dinosaur to our list ");
                Console.WriteLine("REMOVE: To Delete a dinosaur from our list ");
                Console.WriteLine("TRANSFER: To Update the Enclosure Info for one of our current dinosaurs ");
                Console.WriteLine("SUMMARY: To see how many Carnivores and Herbivores we have ");
                Console.WriteLine("QUIT: To close the application ");
                Console.WriteLine();
                Console.Write("What would you like to do? ");
                var choice = Console.ReadLine().ToUpper().Trim();

                // If View:
                if (choice == "VIEW")
                {
                    // Show all the dinosaurs in the list, ordered by WhenAcquired.
                    var dinosaursInOrder = dinosaurs.OrderBy(dinosaur => dinosaur.WhenAcquired);
                    foreach (var dinosaur in dinosaursInOrder)
                    {
                        Console.WriteLine($"We acquired this dinosaur on {dinosaur.WhenAcquired}, their name is {dinosaur.Name} they are a {dinosaur.DietType} they weigh {dinosaur.Weight} pounds and they are in Enclosure Number {dinosaur.EnclosureNumber}.");
                    }
                    // If no dinosaurs are in the park, "Print out" "There aren't any"
                    if (dinosaurs.Count == 0)
                    {
                        Console.WriteLine("We do not have any dinosaurs in our park yet");
                    }
                }
                // If Add: Add a new Dinosaur to the list
                if (choice == "ADD")
                {
                    // Prompt for the Name, DietType, Weight, and EnclosureNumber. WhenAcquired must be set by the code
                    Console.Write("What is the Name of the New Dinosaur? ");
                    var newDinosaurName = Console.ReadLine();
                    Console.Write("What is the Diet Type of the New Dinosaur? ");
                    var newDinosaurDietType = Console.ReadLine();
                    Console.Write("What is the Weight of the New Dinosaur? ");
                    var newDinosaurWeight = int.Parse(Console.ReadLine());
                    Console.Write("What is the Enclosure Number of the New Dinosaur? ");
                    var newDinosaurEnclosureNumber = int.Parse(Console.ReadLine());
                    // Make a New Dinosaur
                    var newDinosaur = new Dinosaur()
                    {
                        Name = newDinosaurName,
                        DietType = newDinosaurDietType,
                        Weight = newDinosaurWeight,
                        EnclosureNumber = newDinosaurEnclosureNumber,
                        WhenAcquired = DateTime.Now,
                    };
                    // Add the dinosaur to the list
                    dinosaurs.Add(newDinosaur);
                }
                // If Remove: 
                if (choice == "REMOVE")
                {
                    // Prompt the user for the dinosaur's name
                    Console.Write("What is the Name of the Dinosaur you want to remove? ");
                    var nameOfDinosaur = Console.ReadLine();
                    // Find the dinosaur with that name
                    var foundDinosaur = dinosaurs.Find(dinosaur => dinosaur.Name == nameOfDinosaur);
                    // Remove the found dinosaur
                    dinosaurs.Remove(foundDinosaur);
                }
                // If Transfer: 
                if (choice == "TRANSFER")
                {
                    // Prompt the user for the dinosaur's name
                    Console.Write("What is the Name of the Dinosaur you want to Transfer? ");
                    var nameOfDinosaur = Console.ReadLine();
                    // Find the dinosaur with that name
                    var foundDinosaur = dinosaurs.Find(dinosaur => dinosaur.Name == nameOfDinosaur);
                    // Prompt for the New EnclosureNumber
                    Console.Write("What Enclosure Number would you like to Transfer the Dinosaur to? ");
                    // Update the EnclosureNumber of that dinosaur
                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    foundDinosaur.EnclosureNumber = newEnclosureNumber;
                }
                // If Summary:  
                if (choice == "SUMMARY")
                {
                    // Display the number of Carnivores and number of Herbivores
                    var numberOfCarnivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Carnivore");
                    Console.WriteLine($"We have a total of {numberOfCarnivores} Carnivores in our Park");
                    // Display the number of Herbivores
                    var numberOfHerbivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Herbivore");
                    Console.WriteLine($"We have a total of {numberOfHerbivores} Herbivores in our Park");
                }

                // If Quit: Stop the Program
                // --- If the user's choice is QUIT
                if (choice == "QUIT")
                {
                    // ---- set the Bool to TRUE
                    userHasChosenToQuit = true;
                }
                // ----- Back to loop
            }

            // Say Goodbye
            BannerMessage("Thank you for visiting, Please come again.");

        }
    }
}
