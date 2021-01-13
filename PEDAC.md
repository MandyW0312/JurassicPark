"P" Problem

- Creating an app that manages a zoo full of dinosaurs

- The app will do the following:
  -- View: Show all the dinosaurs in the list
  -- Add: Add a new dinosaur to the list
  -- Remove: Delete the dinosaur's info from the list
  -- Transfer: Update the dinosaur from one enclosure to another
  -- Summary: Display the number of dinosaurs who are carnivores and herbivores
  -- Quit: Stop the program

"E" Examples

- Name: Natasha, DietType: Herbivore, WhenAcquired: DateTime.Now, Weight: 14250, EnclosureNumber: 4;

- Name: Loki, DietType: Carnivore, WhenAcquired: DateTime.Now, Weight: 3000, EnclosureNumber: 75;

- Name: Jarvis, DietType: Herbivore, WhenAcquired: DateTime.Now, Weight: 6850, EnclosureNumber: 83;

"D" Data Structure

- Dinosaur (class)
  -- Name: string
  -- DietType: string
  -- WhenAcquired: DateTime.Now
  -- Weight: int
  -- EnclosureNumber: int

  -- Method: Description: "Print out" a description of the dinosaur to include all of the properties

"A" Algorithm

- Welcome the user to the app

- While the user hasn't chosen to Quit:
  -- Before the loop, set the Bool to False
  --- While the Bool is False
  --- Show the Menu
  --- If the user's choice is QUIT
  ---- set the Bool to TRUE
  ----- Back to loop
- Display to them the menu Options:
- If View: Show all the dinosaurs in the list, ordered by WhenAcquired.
  --- If no dinosaurs are in the park, "Print out" "There aren't any"
- If Add: Add a new Dinosaur to the list
  --- Prompt for the Name, DietType, Weight, and EnclosureNumber. WhenAcquired must be set by the code
  --- Add the dinosaur to the list
- If Remove: Prompt the user for the dinosaur's name
  --- Find the dinosaur with that name
  --- Remove the found dinosaur
- If Transfer: Prompt the user for the dinosaur's name
  --- Find the dinosaur with that name
  --- Prompt for the New EnclosureNumber
  --- Update the EnclosureNumber of that dinosaur
- If Summary: Display the number of Carnivores and number of Herbivores
- If Quit: Stop the Program

- Say Goodbye
