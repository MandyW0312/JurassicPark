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
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            var userInputAsNumber = int.Parse(userInput);
            return userInputAsNumber;
        }

        static Dinosaur PromptAndFindDinosaur(List<Dinosaur> listOfDinosaursToSearch)
        {
            var nameOfDinosaur = PromptForString("What is the Name of the Dinosaur you want to locate? ");
            var foundDinosaur = listOfDinosaursToSearch.Find(dinosaur => dinosaur.Name == nameOfDinosaur);
            return foundDinosaur;
        }
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
                   WhenAcquired = DateTime.Today,
                   Weight = 14250,
                   EnclosureNumber = 4,
              },
              new Dinosaur(){
                    Name = "Loki",
                   DietType = "Carnivore",
                   WhenAcquired = DateTime.Today,
                   Weight = 3000,
                   EnclosureNumber = 75,
              },
              new Dinosaur(){
                Name = "Jarvis",
                   DietType = "Herbivore",
                   WhenAcquired = DateTime.Today,
                   Weight = 6850,
                   EnclosureNumber = 83,
              },
            };

            BannerMessage("Welcome to Jurassic Park");

            var userHasChosenToQuit = false;
            while (userHasChosenToQuit == false)
            {
                Console.WriteLine();
                Console.WriteLine("Menu: ");
                Console.WriteLine("VIEW ALL: To View a list of our dinosaurs ");
                Console.WriteLine("VIEW BY DATE: To View a list of our dinosaurs that were acquired after a date you choose ");
                Console.WriteLine("VIEW BY ENCLOSURE: This allows you to View a list of our dinosaurs by their Enclosure Number ");
                Console.WriteLine("ADD: To Add a new dinosaur to our list ");
                Console.WriteLine("REMOVE: To Delete a dinosaur from our list ");
                Console.WriteLine("TRANSFER: To Update the Enclosure Info for one of our current dinosaurs ");
                Console.WriteLine("SUMMARY: To see how many Carnivores and Herbivores we have ");
                Console.WriteLine("QUIT: To close the application ");
                Console.WriteLine();
                Console.Write("What would you like to do? ");
                var choice = Console.ReadLine().ToUpper().Trim();


                if (choice == "VIEW")
                {
                    var dinosaursInOrder = dinosaurs.OrderBy(dinosaur => dinosaur.WhenAcquired);
                    foreach (var dinosaur in dinosaursInOrder)
                    {
                        Console.WriteLine($"We acquired this dinosaur on {dinosaur.WhenAcquired}, their name is {dinosaur.Name} they are a {dinosaur.DietType} they weigh {dinosaur.Weight} pounds and they are in Enclosure Number {dinosaur.EnclosureNumber}.");
                    }

                    if (dinosaurs.Count == 0)
                    {
                        Console.WriteLine("We do not have any dinosaurs in our park yet");
                    }
                }

                if (choice == "VIEW BY DATE")
                {
                    var dateForSearch = DateTime.Parse(PromptForString("What date would you like to search for in our list? "));
                    var searchDate = dinosaurs.Where(dinosaur => dinosaur.WhenAcquired >= dateForSearch);
                    foreach (var dinosaur in searchDate)
                    {
                        Console.WriteLine($"The Dinosaurs acquired after {dateForSearch} is {dinosaur.Name}");
                    }

                }

                if (choice == "VIEW BY ENCLOSURE")
                {
                    var enclosureNumberForSearch = PromptForInteger("What Enclosure Number would you like to search for in out list? ");
                    var foundDinosaur = dinosaurs.Where(dinosaur => dinosaur.EnclosureNumber == enclosureNumberForSearch);
                    foreach (var dinosaur in foundDinosaur)
                    {
                        Console.WriteLine($"The Dinosaurs listed in the Enclosure Number {enclosureNumberForSearch} are {dinosaur.Name}");
                    }
                }

                if (choice == "ADD")
                {


                    var newDinosaurName = PromptForString("What is the Name of the New Dinosaur? ");
                    var newDinosaurDietType = PromptForString("What is the Diet Type of the New Dinosaur? ");
                    var newDinosaurWeight = PromptForInteger("What is the Weight of the New Dinosaur? ");
                    var newDinosaurEnclosureNumber = PromptForInteger("What is the Enclosure Number of the New Dinosaur? ");

                    var newDinosaur = new Dinosaur()
                    {
                        Name = newDinosaurName,
                        DietType = newDinosaurDietType,
                        Weight = newDinosaurWeight,
                        EnclosureNumber = newDinosaurEnclosureNumber,
                        WhenAcquired = DateTime.Today,
                    };
                    dinosaurs.Add(newDinosaur);
                }

                if (choice == "REMOVE")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);
                    dinosaurs.Remove(foundDinosaur);
                }

                if (choice == "TRANSFER")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);
                    dinosaurs.Remove(foundDinosaur);
                    Console.Write("What Enclosure Number would you like to Transfer the Dinosaur to? ");

                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    foundDinosaur.EnclosureNumber = newEnclosureNumber;
                    Console.WriteLine($"{foundDinosaur.Name} is now in Enclosure {foundDinosaur.EnclosureNumber}");
                }

                if (choice == "SUMMARY")
                {
                    var numberOfCarnivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Carnivore");
                    Console.WriteLine($"We have a total of {numberOfCarnivores} Carnivores in our Park");

                    var numberOfHerbivores = dinosaurs.Count(dinosaur => dinosaur.DietType == "Herbivore");
                    Console.WriteLine($"We have a total of {numberOfHerbivores} Herbivores in our Park");
                }

                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
            }
            BannerMessage("Thank you for visiting, Please come again.");

        }
    }
}
