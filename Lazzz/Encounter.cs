/*
 * Created by SharpDevelop.
 * User: william reyes
 * Date: 15/12/2023
 * Time: 11:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazLabyrinth
{
	/// <summary>
	/// Description of Encounters.
	/// </summary>
	class Encounters
	{
		private static Random rand = new Random();
        public static bool mainLoop = true;

        // Constructor
        public static void RunGame()
        {
            while (mainLoop)
            {
            	RandomEncounter();
            }
        }
		//Encounter Generic
		
		//Encounters
		public static void FirstEncounter()
		{
			CmpltnLaz.PrintLogo3();
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("You check your supplies for a second time as you never know when you'll run out of supplies. You now know that you must be careful.");
			Console.WriteLine("You spotted the slime. Unsheathe your sword and get into your fighting stance and charged.");
			Console.ReadKey();
			Combat(false, "Slime", 2, 2);
		}
		public static void BasicEncounter()
		{
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("After you defeat a monster, another always appear. They seem to be never ending, the saving grace is that these slimes are easy to defeat...");
			Console.ReadKey();
			Combat(true,"",0,0);
		}
		public static void IfBoss()
        {
            Console.Clear();
            CmpltnLaz.PrintLogo4();
            Console.WriteLine("Do you want to fight the boss to ascend to the next floor?..");
            Console.WriteLine("WARNING!!!!");
            Console.WriteLine("UPGRADE YOUR EQUIPMENT FIRST!!!");
            Console.WriteLine("Press Y for YES and N for No.");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "y" || ans.ToLower() == "yes")
            {
                Boss();
                Console.Clear();
                CmpltnLaz.PrintLogo4();
                Console.WriteLine("Congratulations on defeating the first boss!");
                SecondFloor.FirstEncounter();
            }
            else if (ans.ToLower() == "n" || ans.ToLower() == "yes")
            {
                Console.Clear();
                CmpltnLaz.PrintLogo4();
                Console.WriteLine("You decide not to fight the boss and continue to explore the current floor...");
                Console.ReadKey();
            }
        }
		public static void Boss()
		{
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("It looks like it mutated far beyond than the others.");
			Console.WriteLine("His height is far more beyond than what the other goblins are capable of, muscles bulging with sharpen teeth to booth.");
			Console.WriteLine("It looks far more composed and it doesn't attack immediately. Lets get ready for battle! ");
			Console.ReadKey();
			Combat(false, "Blarggan, Hob Goblin", 2, 2);
		}
		//Encounter Tools
		public static void RandomEncounter()
		{
		    switch (rand.Next(0, 2))
		    {
		        case 0:
		            BasicEncounter();
		            break;
		        case 1:
		            IfBoss();
		            break;
		    }
		}

		public static void Combat(bool random, string name, int power, int health)
		{
			string n = "";
			int p = 0;
			int h = 0;
			if (random)
			{
				n = GetName();
				p = rand.Next(2, 2);
				h = rand.Next(2, 2);
			}
			else
			{
				n = name;
				p = power;
				h = health;
			}
			while (h > 0)
			{
				Console.Clear();
				CmpltnLaz.PrintLogo4();
				Console.WriteLine(n);
				Console.WriteLine(p +" Power" + " / " + h + " Health");
				Console.WriteLine("=====================");
				Console.WriteLine("| (A)ttack (D)efend |");
				Console.WriteLine("|  (R)un    (H)eal  |");
				Console.WriteLine("=====================");
				Console.WriteLine("Potions " + Program.currentPlayer.potion + " Health " + Program.currentPlayer.health);
				string input = Console.ReadLine();
				if (input.ToLower() == "a" || input.ToLower() == "attack")
				{
					//attack
					Console.WriteLine("With haste you surge forth, your sword flying in your hands! AS you pass, the "+n+" strikes you.");
					int damage = p - Program.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
					int attack = Program.currentPlayer.weaponValue + rand.Next(3, 3);
					Console.WriteLine("You lose "+ damage + " health and deal " + attack + " damage");
					Program.currentPlayer.health -= damage;
					h -= attack;
				}
				else if (input.ToLower() == "d" || input.ToLower() == "defend")
				{
					//defend
					Console.WriteLine("As the  " + n + " prepares to strike, you ready your sword in a defensive stance");
					int damage = (p/4) - Program.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
					int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;
					Console.WriteLine("You lose "+ damage + " health and deal " + attack + " damage");
					Program.currentPlayer.health -= damage;
					h -=attack;
				}
				else if (input.ToLower() == "r" || input.ToLower() == "run")
				{
					//run
					if (rand.Next(0, 2) == 0)
					{
						Console.WriteLine("As you sprint aways from the "+n+" its strike catches you in the back, sending you sprawl");
						int damage = p - Program.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						Console.WriteLine("You lose "+ damage+" health and are unable to escape");
						Program.currentPlayer.health -= damage;
					}
					else
					{
						Console.WriteLine("You use crazy move to escape from "+n+". But it knows you will be back.");
						Console.ReadKey();
						Shop.LoadShop(Program.currentPlayer);
						//go to store
					}
					
				}
				else if (input.ToLower() == "h" || input.ToLower() == "heal")
			{
			    // Heal
			    if (Program.currentPlayer.potion == 0)
			    {
			        Console.WriteLine("As you desperately grasp for a potion in your bag, all that you feel are empty glass flasks");
			        int damage = p - Program.currentPlayer.armorValue;
			        if (damage < 0)
			            damage = 0;
			        Console.WriteLine("The " + n + " strikes you with a blow and you lose " + damage + " health");
			    }
			    else
			    {
			        Console.WriteLine("You reach into your bag and pull out a glowing, purple flask. You take a long drink.");
			        int potionV = 5;
			        Console.WriteLine("You gain " + potionV + " health");
			        Program.currentPlayer.health += potionV;
			        Program.currentPlayer.potion--;
			    }
			}
				if (Program.currentPlayer.health<=0)
				{
					Console.Clear();
					Console.WriteLine("As the "+n+" stands tall and comes to down to strike you down. You have been slain by " + n);
					CmpltnLaz.PrintLogo2();
					Console.ReadKey();
					Program.MainMenu();
				}
				Console.ReadKey();
			}
			Console.Clear();
			int c = rand.Next(20, 50);
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("As you stand victorious over the "+n+" its body dissolves into " + c + " gold coins");
			Program.currentPlayer.coins += c;
			Console.ReadKey();
		}
		public static string GetName()
		{
			switch (rand.Next(0,3))
			{
				case 0:
					return "Goblin";
				case 1:
					return "Lizard Warrior";
				case 2:
					return "Slime";
			}
			return "Slime";
		}
	}
}
