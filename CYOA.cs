using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */
      // Start by asking for the user's name
      Console.Write("What is your name? ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you investigate?");
      
      Console.Write("Type YES or NO\n");
      string noiseChoice = Console.Readline();
      noiseChoice = noiseChoice.ToUpper();
      
      if (noiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
      } else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
        Console.WriteLine("You walk towards it. Do you open it or knock?");
      }
      
      Console.WriteLine("Type OPEN or KNOCK\n");
      string doorChoice = Console.Readline();
      doorChoice = doorChoice.ToUpper();
      
      if (doorChoice == "KNOCK") {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
        Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it \"");
        Console.WriteLine("Type your answer: \n");
        string riddleAnswer = Console.ReadLine();
        riddleAnswer = riddleAnswer.ToUpper();
        if (riddleAnswer == "NOTHING")
        {
          Console.WriteLine("Correct. The door opens to nothing");
        }
        
      } else if (doorChoice == "OPEN") {
           
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.WriteLine("Enter a number (1-3:)\n");
          string keyChoice = Console.ReadLine();
        
          switch (keyChoice) {
            case "1":
              Console.WriteLine("You choose the first key. Lucky Choice! The door opens and NOTHING is there. Strange...");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open.");
              break;
            case "3":
              Console.WriteLine("Poor choice. As you turn the key, a trap door opens and you fall to your death.");
              break;
          }
      }  
      Console.WriteLine("THE END"); 
        
      }
