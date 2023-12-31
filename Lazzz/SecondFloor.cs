/*
 * Created by SharpDevelop.
 * User: william reyes
 * Date: 22/12/2023
 * Time: 12:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazLabyrinth
{
    /// <summary>
    /// Description of Encounters.
    /// </summary>
    class SecondFloor
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

        // Encounters
        public static void FirstEncounter()
        {
            CmpltnLaz.PrintLogo3();
			Console.Clear();
			CmpltnLaz.PrintLogo4();
            Console.WriteLine("After you ascended to the second floor, all you see is a forest with a thick fog.");
            Console.WriteLine("It's impossible to see anything within the fog.");
            Console.WriteLine("The fog gradually got thinner until it disipated.");
            Console.WriteLine("You see a wolf-like monster that is growling and getting ready to attack you.");
            Console.WriteLine("It pounces onto you and you block it with your sword...");
            Console.ReadKey();
            Combat(false, "Lycan", 3, 4);
            RunGame();
        }

        public static void BasicEncounter()
        {
            Console.Clear();
            CmpltnLaz.PrintLogo4();
            Console.WriteLine("After you defeat the mob, you take a breather and check your supplies for the encounter.");
            Console.ReadKey();
            Combat(true, "", 0, 0);
            
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
                Console.WriteLine("Congratulations on defeating the second boss!");
                Console.ReadKey();
                ThirdFloor.FirstEncounter();
            }
            else if (ans.ToLower() == "n" || ans.ToLower() == "no")
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
            Console.WriteLine("It seems to have wings with the head of what seems to be like an eagle. With the body having to inhabit that of a lion. It's what they call a Griffin.");
            Console.ReadKey();
            Combat(false, "Kestrel, The Guardian", 3, 4);
            
        }

        // Encounter Tools
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
                p = rand.Next(3, 3);
                h = rand.Next(4, 4);
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
                Console.WriteLine(p + " Power" + " / " + h + " Health");
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|  (R)un    (H)eal  |");
                Console.WriteLine("=====================");
                Console.WriteLine("Potions " + Program.currentPlayer.potion + " Health " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    // Attack
                    Console.WriteLine("With haste you surge forth, your sword flying in your hands! As you pass, the " + n + " strikes you.");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = Program.currentPlayer.weaponValue + rand.Next(4, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    // Defend
                    Console.WriteLine("As the " + n + " prepares to strike, you ready your sword in a defensive stance");
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    // Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the " + n + ", its strike catches you in the back, sending you sprawling");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape");
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Console.WriteLine("You use a crazy move to escape from " + n + ". But it knows you will be back.");
                        Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                        // Go to store
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
                        Console.WriteLine("The " + n + " strikes you with a blow, and you lose " + damage + " health");
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
                if (Program.currentPlayer.health <= 0)
                {
                    Console.WriteLine("As the " + n + " stands tall and comes down to strike you down. You have been slain by " + n);
                    CmpltnLaz.PrintLogo2();
                    Console.ReadKey();
                    Program.MainMenu();
                }
                Console.ReadKey();
            }
            Console.Clear();
            int c = rand.Next(75, 100);
            CmpltnLaz.PrintLogo4();
            Console.WriteLine("As you stand victorious over the " + n + ", its body dissolves into " + c + " gold coins");
            Program.currentPlayer.coins += c;
            Console.ReadKey();
        }
        public static string GetName()
        {
            switch (rand.Next(0, 3))
            {
                case 0:
                    return "Cyclops";
                case 1:
                    return "Leprechaun";
                case 2:
                    return "Lycan";
            }
            return "Lycan";
        }
    }
}
