/*
 * Created by SharpDevelop.
 * User: william reyes
 * Date: 27/12/2023
 * Time: 8:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazLabyrinth
{
	/// <summary>
	/// Description of Encounters.
	/// </summary>
	class FifthFloor
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
			Console.WriteLine("As you leave the fourth floor's winter cold, you enter a forest with a much more bearable conditions.");
			Console.WriteLine("Seems like the fifth floor is a much more neutral environment.");
			Console.WriteLine("Through the forest is a run down castle. A lone castle in the middle, with plant life overrunning its stone slab wall.");
			Console.WriteLine("You see a human like person, poise with a spear on both hands and was getting ready to charge you.");
			Console.WriteLine("It pounces onto you and you blocked it with your sword....+");
			Console.ReadKey();
			Combat(false, "Lancelot, The Impeded Spear", 6, 10);
			RunGame();
		}
		public static void BasicEncounter()
		{
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("After you defeat a monster, another always appear. They seem to be never ending...");
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
                AfterGame();
                Console.ReadKey();
            }
            else if (ans.ToLower() == "n" || ans.ToLower() == "no")
            {
                Console.Clear();
                CmpltnLaz.PrintLogo4();
                Console.WriteLine("You decide not to fight the boss and continue to explore the current floor...");
                Console.ReadKey();
            }
        }
		public static void AfterGame()
		{
			    Console.Clear();
			    CmpltnLaz.PrintLogo4();
			    Console.WriteLine("With the mutated creature falls down to its knees.");
                Console.WriteLine("It raises his hand, pointing its finger at you. Mouthing words that you are not able to hear clearly...");
                Console.WriteLine("Suddenly, a gripping feeling encompasses your entire torso.");
                Console.WriteLine("The growing feeling of you being gripped by an invisible hand.");
                Console.WriteLine("You dropped your sword, as you clutch at your heart.");
                Console.WriteLine("You drop to your hands and knees, eyes growing heavy as each second passes by.");
                Console.WriteLine("Laz, is still mouthing intelligible words at you.");
                Console.WriteLine("Then you realize, you are being cursed.");
                Console.WriteLine("You finally close your eyes. When you opened them, a band of adventures are in front of you.");
                Console.WriteLine("Barking orders to their comrades as you rip their leader in half, you realize that you are much taller than you remember.");
                Console.WriteLine("With you having no control over your body.");
                Console.WriteLine("Despair spread to the faces of the adventures in front of you, as you trudge towards their position.");
                Console.WriteLine("A gargled word escaped from your mouth.");
                Console.WriteLine("Heeellpp.");
                Console.ReadKey();
                CmpltnLaz.PrintLogo3();
                CmpltnLaz.PrintLogo2();
                System.Environment.Exit(0);
                
		}
		public static void Boss()
		{
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("This one is entirely hideous. On top are what to be like three heads, with six arms protruding from both its sides. Two swords on one pair of hands, a lance on the other pair and a magic staff on the last pair of hands. It resembles the last party that managed to reach the fifth floor but never came out.");
			Console.ReadKey();
			Combat(false, "Laz, The Unwanted Sentinel", 6, 10);
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
		            IfBoss(); // Check if the boss was defeated
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
				p = rand.Next(6, 6);
				h = rand.Next(10, 10);
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
				Console.WriteLine(n);
				CmpltnLaz.PrintLogo4();
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
					int attack = Program.currentPlayer.weaponValue + rand.Next(7,7);
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
					int attack = Program.currentPlayer.weaponValue/2;
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
					Console.WriteLine("As the "+n+" stands tall and comes to down to strike you down. You have been slain by " + n);
					CmpltnLaz.PrintLogo2();
					Console.ReadKey();
					Program.MainMenu();
				}
				Console.ReadKey();
			}
			Console.Clear();
			int c = rand.Next(75, 100);
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
					return "Lancelot, The Impeded Spear";
				case 1:
					return "Merlin, The Soulless Mage";
				case 2:
					return "Arthur, The Broken King";
			}
			return "Lancelot, The Impeded Spear";
		}
	}
}

