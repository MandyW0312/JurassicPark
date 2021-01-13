using System;

namespace JurassicPark
{
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
                // --- If the user's choice is QUIT
                if (choice == "QUIT")
                {
                    // ---- set the Bool to TRUE
                    userHasChosenToQuit = true;
                }
                // ----- Back to loop
            }

            // View: Show all the dinosaurs in the list, ordered by WhenAcquired.
            // If no dinosaurs are in the park, "Print out" "There aren't any"
            // Add: Add a new Dinosaur to the list
            // Prompt for the Name, DietType, Weight, and EnclosureNumber. WhenAcquired must be set by the code
            // Add the dinosaur to the list
            // Remove: Prompt the user for the dinosaur's name
            // Find the dinosaur with that name
            // Remove the found dinosaur
            // Transfer: Prompt the user for the dinosaur's name
            // Find the dinosaur with that name
            // Prompt for the New EnclosureNumber
            // Update the EnclosureNumber of that dinosaur
            // Summary: Display the number of Carnivores and number of Herbivores  
            // Quit: Stop the Program

            // Say Goodbye
            BannerMessage("Thank you for visiting, Please come again.");

        }
    }
}
