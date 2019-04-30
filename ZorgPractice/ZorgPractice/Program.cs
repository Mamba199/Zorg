using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice
{
	class Program
	{
		// Global Strings
		


		// Global Integers


		 public static void Main()
		{
			
			Console.WriteLine("Welcome to the Zorg Game! Press enter the e key to start q key to quit or the c key to view controls.");
			Beginning();

			












		}

		static void Beginning()
		{

			string beginningInput = "";


			beginningInput = Console.ReadLine();

			if (beginningInput == "e")
			{
				/*Console.WriteLine("User pressed e!");
				Console.ReadLine();*/
				Console.Clear();
				Phase1();
			}

			if (beginningInput == "q")
			{
				Environment.Exit(0);
				Console.ReadLine();
			}

			if (beginningInput == "c")
			{
				Controls();
			}


			if (beginningInput != "e" || beginningInput != "q" || beginningInput != "c")
			{

				Console.WriteLine("Invalid Key, please try again.");
				
				Beginning();
						
			}

			 
		}

		static void Phase1()
		{
			string inputAction;

			Console.WriteLine("\nYou start off in a small village, only carrying a sword, shield and health \npotion. The villagers have informed you that they are being " +
				"terroized by the\n local ogres that live up in the mountains close by\n");
			inputAction = Console.ReadLine();

			switch (inputAction)
			{
				case "go forward":
					Console.WriteLine("I am going forward somewhere dunno yet\n");
					inputAction = Console.ReadLine();
					break;

				case "go backward":
					Console.WriteLine("There is nothing behind you except more of the village. Perhaps you should go and help with the ogre problem.\n");
					inputAction = Console.ReadLine();
					break;

				case "go left":
					Console.WriteLine("You enter the local village shop, here you can buy all sorts of items that you might need on your adventures\n");
					inputAction = Console.ReadLine();
					break;

				case "go right":
					Console.WriteLine("You see a villagers home, it is locked.");
					inputAction = Console.ReadLine();
					break;

				case "q":
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("I did not understand that, please try inputting something else.");
					Phase1();
					break;

			}
			



			/*if (inputAction == "go forward")
			{
				Console.WriteLine("I am going forward somewhere dunno yet\n");
				inputAction = Console.ReadLine();
			}
			if (inputAction == "go backward")
			{
				Console.WriteLine("There is nothing behind you except more of the village. Perhaps you should go and help with the ogre problem.\n");
				inputAction = Console.ReadLine();
			}
			if (inputAction == "go left")
			{

				Console.WriteLine("You enter the local village shop, here you can buy all sorts of items that you might need on your adventures\n");
				inputAction = Console.ReadLine();
			}

			if (inputAction == "go right")
			{
				Console.WriteLine("You see a villagers home, it is locked.");
				inputAction = Console.ReadLine();
			}

			if (inputAction == "q")
			{
				Environment.Exit(0);
			}*/
		}


		static void Controls()
		{
			string leaveControls;

			Console.WriteLine("\nWelcome to the controls, here you will be able to view all the buttons that are usuable within the game.");
			Console.WriteLine("\nThe keys usable in the game are:");
			Console.WriteLine("\ne : starts the game (if at the beginning)");
			Console.WriteLine("q : quits the game");
			Console.WriteLine("c : controls (if at the beginning)");
			Console.WriteLine("i : inventory");
			Console.WriteLine("\n if you want to go in a certain direction, type 'go left' 'go right' \n'go forward' 'go backward'");
			Console.WriteLine("If you want to pick up an item (if there is one), type 'pick up <item>'");
			Console.WriteLine("\nIf you want to interact with something, type 'interact with <object>'");
			Console.WriteLine("\nPress the c button again to return to the main menu.");

			leaveControls = Console.ReadLine();

			if (leaveControls == "c")
			{
				Console.Clear();
				Main();
			}
			else
			{

				Console.WriteLine("CONTROLS invalid key, please try again");
				Console.ReadLine();
				//Controls();
			}

			// ERROR HERE: Need the if statement to loop over without the options displaying again IF the key is not c

			

		}

		static void Exit()
		{
			string isExitButtonPressed = Console.ReadLine();

			if (isExitButtonPressed == "q")
				Environment.Exit(0);

		}

	}
}
