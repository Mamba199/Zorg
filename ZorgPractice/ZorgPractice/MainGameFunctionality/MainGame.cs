﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorgPractice.CommonFunctionality;
using ZorgPractice.ItemSystem;
using ZorgPractice.Player;

namespace ZorgPractice.MainGameFunctionality
{
	internal class MainGame // Chris Gray Worthy
	{
		#region Constructor
		internal MainGame()
		{
			_Player = new Character();
		}
		#endregion

		#region Propertys

		#endregion

		#region Public Methods

		#endregion

		#region Internal Methods
		internal void Beginning()
		{
			
			Weapon _IronSword = new Weapon(9001, 1, WeaponType.Sword);
			Armour _IronArmourHelm = new Armour(2, 10000, ArmourType.Helm);

			_IronArmourHelm.ItemName = "Iron Armour Helm";
			_IronSword.ItemName = "Iron Sword";
			_Player.Inventory.Add(_IronArmourHelm, 1);
			_Player.Inventory.Add(_IronSword, 5);
			foreach (Item item in _Player.Inventory.ItemCollection.Keys)
			{
				Console.WriteLine($"Player has found {_Player.Inventory.ItemCollection[item]} {item.ItemName}");
			}



			Console.WriteLine("Welcome to the Zorg Game! Press enter the e key to start q key to quit or the c key to view controls.");

			string beginningInput = Console.ReadLine();

			if (beginningInput == "e")
			{
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

		internal void Phase1()
		{
			string inputAction;

			Console.WriteLine("\nYou start off in a small village, only carrying a sword, shield and health \npotion. The villagers have informed you that they are being " +
				"terroized by the\n local ogres that live up in the mountains close by\n");
			inputAction = Console.ReadLine();

			switch (inputAction)
			{
				case "go forward":
					Console.WriteLine("\nYou walk forward until you leave the village and enter the forest.\n");
					Console.Clear();
					P1Forest();
					break;

				case "go backward":
					Console.WriteLine("There is nothing behind you except more of the village. Perhaps you should go and help with the ogre problem.\n");
					Console.ReadLine();
					Console.Clear();
					Phase1();
					break;

				case "go left":
					Console.WriteLine("You enter the local village shop, here you can buy all sorts of items that you might need on your adventures\n");
					Console.ReadLine();
					Console.Clear();
					P1Shop();
					break;

				case "go right":
					Console.WriteLine("You see a villagers home, it is locked.\n");
					inputAction = Console.ReadLine();
					break;

				case "q":
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("I did not understand that, please try inputting something else.\n");
					Console.ReadLine();
					Console.Clear();
					Phase1();
					break;
			}
		}

		internal void P1Forest()
		{
			Console.WriteLine("You are now in the forest gg wp");
			Console.ReadLine();
		}

		internal void Controls()
		{
			string leaveControls;

			Console.WriteLine("\nWelcome to the controls, here you will be able to view all the buttons that are usuable within the game.");
			Console.WriteLine("DO NOT USE ANY UPPER CASE LETTERS IN THIS GAME! The game is case sensitive so using any capital letters will cause the input to be invalid");
			Console.WriteLine("\nThe keys usable in the game are:");
			Console.WriteLine("\ne : starts the game (if at the beginning)");
			Console.WriteLine("q : quits the game");
			Console.WriteLine("c : controls (if at the beginning)");
			Console.WriteLine("i : inventory");
			Console.WriteLine("\n if you want to go in a certain direction, type 'go left' 'go right' \n'go forward' 'go backward'");
			Console.WriteLine("If you want to pick up an item (if there is one), type 'pick up <item>'");
			Console.WriteLine("\nIf you want to interact with something, type 'interact with <object>'");
			Console.WriteLine("\nIf you want to purchase an item from a shop, type 'purchase <item>'");
			Console.WriteLine("\nPress the c button again to return to the main menu.");

			leaveControls = Console.ReadLine();

			if (leaveControls == "c")
			{
				Console.Clear();
				Beginning(); // REMEMBER TO PUT A MAIN LOOP
			}
			else
			{
				Console.WriteLine("CONTROLS invalid key, please try again");
				Console.ReadLine();
				Console.Clear();
				Controls();
			}

			// ERROR HERE: Need the if statement to loop over without the options displaying again IF the key is not c
		}

		internal void P1Shop()
		{
			int purchaseHealthPotion = 5;
			int purchaseWoodenBow = 10;
			int purchaseQuiver = 10;
			int purchaseArrows = 2;
			string inputPurchase;

			Console.WriteLine("You are now in the village shop, the shop keeper is selling:\n");
			Console.WriteLine("Health Potion - 5 Coins");
			Console.WriteLine("Wooden Bow - 10 Coins");
			Console.WriteLine("Quiver - 10 Coins");
			Console.WriteLine("Arrows - 2 Coins Each\n");
			Console.WriteLine("Currently you have " + playerCoins + " coins");
			Console.WriteLine("The shop keeper asks 'Would you like to purchase something?'");

			inputPurchase = Console.ReadLine();

			switch (inputPurchase)
			{
				case "purchase health potion": // 5 coins
					if (purchaseHealthPotion <= playerCoins)
					{
						playerCoins = playerCoins - purchaseHealthPotion;
						Console.WriteLine("\nCongratulations! You purchased a ");
						noOfHealthPotionsInInventory += 1;
						Console.WriteLine("You now currently have " + noOfHealthPotionsInInventory + " Health Potions!\n"); // This will be later replaced by the array for the inventory.
						Console.WriteLine("You now have " + playerCoins + " coins remaining");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					else
					{
						Console.WriteLine("\nOops! It seems you do not have enough coins to purchase this item.");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					break;

				case "purchase wooden bow": // 10 coins
					if (purchaseWoodenBow <= playerCoins)
					{
						playerCoins = playerCoins - purchaseWoodenBow;
						Console.WriteLine("\nCongratulations! You have purchased a Wooden Bow!");

						Inventory _Player = new Inventory();
						Weapon _WoodenBow = new Weapon(9001, 1, WeaponType.Bow);

						_WoodenBow.ItemName = "Wooden Bow";

						_Player.Add(_WoodenBow, 1);

						foreach (Item item in _Player.ItemCollection.Keys)
						{
							Console.WriteLine($"Player has added {_Player.ItemCollection[item]} {item.ItemName} to their inventory");
						}

						Console.WriteLine("You now have " + playerCoins + " coins remaining");
						Console.ReadLine();

						
					}
					else
					{
						Console.WriteLine("\nOops! It seems you do not have enough coins to purchase this item.");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					break;

				case "purchase quiver": // 5 coins
					if (purchaseQuiver <= playerCoins)
					{
						playerCoins = playerCoins - purchaseQuiver;
						Console.WriteLine("\nCongratulations! You have purchased a Quiver!");

						Weapon _Quiver = new Weapon(0, 10, WeaponType.Quiver);

						_Quiver.ItemName = "Quiver";

						
						
						Console.WriteLine("You now have " + playerCoins + " coins remaining");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					else
					{
						Console.WriteLine("\nOops! It seems you do not have enough coins to purchase this item.");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					break;

				case "purchase arrow": // 2 coins each
					if (purchaseWoodenBow <= playerCoins)
					{
						playerCoins = playerCoins - purchaseArrows;
						Console.WriteLine("\nCongratulations! You have purchased an Arrow!");
						Console.WriteLine("You are now in possession of an Arrow!"); // arrow count from array will appear here
						Console.WriteLine("You now have " + playerCoins + " coins remaining");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					else
					{
						Console.WriteLine("\nOops! It seems you do not have enough coins to purchase this item.");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					break;

				case "go backward":
					string inputGoBackward;

					Console.WriteLine("Are you sure you want to go back?");
					inputGoBackward = Console.ReadLine();

					if (inputGoBackward == "yes")
					{
						Console.Clear();
						Phase1();
					}
					else if (inputGoBackward == "no")
					{
						Console.Clear();
						P1Shop();
					}
					else
					{
						Console.WriteLine("Invalid choice entered.");
						Console.ReadLine();
						Console.Clear();
						P1Shop();
					}
					break;

				default:
					Console.WriteLine("Invalid choice entered.");
					Console.ReadLine();
					Console.Clear();
					P1Shop();
					break;
			}
			//TODO: Create inventory array for items, Make variables in function global, make function cleaner
		}

		internal void Exit()
		{
			string isExitButtonPressed = Console.ReadLine();

			if (isExitButtonPressed == "q")
				Environment.Exit(0);
		}
		#endregion

		#region Private Methods

		#endregion

		#region Fields
		private string HealthPotionInInventory = "Health Potion";

		private int playerCoins = 10;
		private int noOfHealthPotionsInInventory = 1;

		private Character _Player;
		#endregion

		#region Constants

		#endregion



		




	}
}

