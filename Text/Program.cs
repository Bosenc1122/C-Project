using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("# What is your name? ");
      // Use the Users input for the name
      string name = Console.ReadLine();
      Console.WriteLine($"~ Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("# Type YES or NO: ");
      string noiseChoice = Console.ReadLine().ToUpper();
      // Uses the Yes or no input to choose the next options.
      if (noiseChoice == "YES") 
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
      } 
      else
      {
        if (noiseChoice != "NO")
        {
          Console.WriteLine("~ Incorrect input! We consider it as a NO.");
        }
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
      }
      Console.Write("# Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine().ToUpper();
      // users choice has many different options for the story to go.
      if (doorChoice == "KNOCK")
      {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"");
        Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.Write("# Type your answer: ");
        string riddleAnswer = Console.ReadLine().ToUpper();
        if (riddleAnswer == "NOTHING") 
        {
          Console.WriteLine("The door opens and NOTHING is there.");
          Console.WriteLine("You turn off the light and run back to your room and lock the door.");
        }
        else 
        {
          Console.WriteLine("You give your answer and hear the voice reply");
          Console.WriteLine("'You have answered my question incorrectly, return from whence you came.'");
        }
      }
      else if (doorChoice == "OPEN")
      {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("# Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice!");
            Console.WriteLine("The door opens and NOTHING is there. Strange...");
            Console.WriteLine("You see two ways out of the room, the window and another door. Which do you check?");
            Console.Write("# Type WINDOW or DOOR: ");
            string CheckChoice = Console.ReadLine().ToUpper();
            if (CheckChoice == "WINDOW") 
            {
              Console.WriteLine("You Walk towards the Window and peer out of it. As you do something pushes you from behind and you fall to your doom.");
            } 
            else if (CheckChoice == "DOOR") 
            {
              Console.WriteLine("You Walk towards the door and open it. From within a ghost of a man rushes out and chases you back towards your room.");
              Console.WriteLine("You quickly lock your door and decide that you will never leave your room in the middle of the night again.");
            } 
            else
            {
              Console.WriteLine("~ Incorrect input! The story ends here...");
            }
            break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open");
            Console.WriteLine("As you reach for a different key to try something hits you from behind knocking you out.");
            Console.WriteLine("When you wake up the next day you can't remember why you fell asleep in the middle of the hallway.");
            break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open");
            Console.WriteLine("You reach for another key, but right before you try it you hear a scream from inside the room.");
            Console.WriteLine("In your fright you rush back to your room and vow to never leave your room at night again.");
            break;
          default:
            Console.WriteLine("~ Incorrect input! The story ends here...");
            break;
        }
      }
      // story ends if user gives an answer that is not recognized
      else 
      {
        Console.WriteLine("~ Incorrect input! The story ends here...");
      }
      Console.WriteLine("THE END");
    }
  }
}
