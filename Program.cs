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
            // Display to them the menu Options:
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
