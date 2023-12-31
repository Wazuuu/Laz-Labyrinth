/*
 * Created by SharpDevelop.
 * User: william reyes
 * Date: 28/12/2023
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazLabyrinth
{
    public class Shop
    {
        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            while (true)
            {
                Console.Clear();

                int armorPrice = 100 * p.armorValue;
                int weaponPrice = 100 * (p.weaponValue + 1);
                int potionPrice = 50; // Adjusted potion price, you can set it as you like
				CmpltnLaz.PrintLogo4();
                Console.WriteLine("        ***SHOP***        ");
                Console.WriteLine("==========================");
                Console.WriteLine("|(W)eapon:           " + weaponPrice);
                Console.WriteLine("|(A)rmor:            " + armorPrice);
                Console.WriteLine("|(P)otions:          " + potionPrice);
                Console.WriteLine("==========================");
                Console.WriteLine("(E)xit");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine( p.name + " 's STATS");
                Console.WriteLine("==========================");
                Console.WriteLine("Current Health " + p.health);
                Console.WriteLine("Coins ````````" + p.coins);
                Console.WriteLine("Weapons Strength: " + p.weaponValue);
                Console.WriteLine("Armor Toughness: " + p.armorValue);
                Console.WriteLine("Potions Quantity: " + p.potion);
                Console.WriteLine("==========================");

                string input = Console.ReadLine().ToLower();

                if (input == "p" || input == "potions")
                {
                    TryBuy("potion", potionPrice, p);
                }
                else if (input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponPrice, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorPrice, p);
                }
                else if (input == "e" || input == "exit")
                {
                    break;
                }
            }
        }

        static void TryBuy(string item, int cost, Player p)
        {
            if (p.coins >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.armorValue++;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("You don't have enough gold");
                Console.ReadKey();
            }
        }
    }
}
