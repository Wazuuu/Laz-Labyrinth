/*
 * Created by SharpDevelop.
 * User: william reyes
 * Date: 13/12/2023
 * Time: 6:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazLabyrinth
{
    class Program
    {
        public static Player currentPlayer = new Player();
        public static int currentFloor = 1; // Start at the first floor

        public static void Main(string[] args)
        {
            MainMenu();

            do
            {
                RunFloor();
            } while (currentFloor <= 5); // Assuming you have three floors, adjust as needed
        }

        private static void RunFloor()
        {
            Console.Clear();
            Console.WriteLine("Entering Floor " + currentFloor + ".....");

            switch (currentFloor)
            {
                case 1:
                    Encounters.RunGame();
                    break;
                case 2:
                    SecondFloor.RunGame();
                    break;
                case 3:
                    ThirdFloor.RunGame();
                    break;
                case 4:
                    FourthFloor.RunGame();
                    break;
                case 5:
                    FifthFloor.RunGame();
                    break;
                // Add more cases for additional floors if needed
                default:
                    Console.WriteLine("Congratulations! You have completed all floors.");
                    break;
            }

            currentFloor++;
        }

		// ... (previous code)

		public static void MainMenu()
		{
		    while (true)
		    {
		        PrintLogo1();
				
  		        // Display the menu in the middle of the console window
                  int menuTopPosition = Console.WindowHeight / 2 + 2; // Increase this value to move the menu further down
                  Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition);
                  Print2("Main Menu:");
                  Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 1);
                  Print2("1. Start Game");
                  Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 2);
                  Print2("2. About");
                  Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 3);
                  Print2("3. Exit");
                  ConsoleKeyInfo keyInfo = Console.ReadKey();
		
		        switch (keyInfo.Key)
		        {
		            case ConsoleKey.D1:
		        		Console.ReadLine();
		                Start();
		                break; 
		            case ConsoleKey.D2:
		                Console.ReadLine();
		                DisplayAbout();
		                break;
		            case ConsoleKey.D3:
		                Console.ReadLine();
		                Console.Clear();
		                CmpltnLaz.PrintLogo5();
						Console.ReadKey();
						System.Environment.Exit(0);
		                return;
		            default:
		                Console.WriteLine("Error! Please press a key between 1 and 3.");
		                Console.ReadLine();
		                MainMenu();
		                break;
		        }
		        break;
		    }
		}

// ... (rest of the code)


			static void PrintLogo1()
			{
			    // Display the ASCII art logo at the top center of the console window
			    string[] logoLines = {
            @"      .                                                                            .                          +   ",
            @"           .                                    +                                          .                      ",
            @"   +   ██▓    ▄▄▄  *   ▒███████▒    ██▓    ▄▄▄       ▄▄▄▄ ▓██   ██▓ ██▀███   ██▓ ███▄ +  █ ▄▄▄█████▓ ██░ ██       ",
            @"      ▓██▒   ▒████▄    ▒ ▒ ▒ ▄▀░   ▓██▒   ▒████▄    ▓█████▄▒██  ██▒▓██ ▒ ██▒▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓██░ ██▒  *   ",
            @"      ▒██░   ▒██  ▀█▄  ░ ▒ ▄▀▒░    ▒██░   ▒██  ▀█▄  ▒██▒ ▄██▒██ ██░▓██ ░▄█ ▒▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░▒██▀▀██░      ",
            @"  *   ▒██░   ░██▄▄▄▄██   ▄▀▒   ░   ▒██░   ░██▄▄▄▄██ ▒██░█▀  ░ ▐██▓░▒██▀▀█▄  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ░▓█ ░██       ",
            @"      ░██████▒▓█   ▓██▒▒███████▒   ░██████▒▓█   ▓██▒░▓█  ▀█▓░ ██▒▓░░██▓ ▒██▒░██░▒██░   ▓██░  ▒██▒ ░ ░▓█▒░██▓      ",
            @"      ░ ▒░▓  ░▒▒   ▓▒█░░▒▒ ▓░▒░▒   ░ ▒░▓  ░▒▒   ▓▒█░░▒▓███▀▒ ██▒▒▒ ░ ▒▓ ░▒▓░░▓  ░ ▒░   ▒ ▒   ▒ ░░    ▒ ░░▒░▒      ",
            @"      ░ ░ ▒  ░ ▒   ▒▒ ░░░▒ ▒ ░ ▒   ░ ░ ▒  ░ ▒   ▒▒ ░▒░▒   ░▓██ ░▒░   ░▒ ░ ▒░ ▒ ░░ ░░   ░ ▒░    ░     ▒ ░▒░ ░      ",
            @"        ░ ░    ░   ▒   ░ ░ ░ ░ ░     ░ ░    ░   ▒    ░    ░▒ ▒ ░░    ░░   ░  ▒ ░   ░   ░ ░   ░       ░  ░░ ░      ",
            @"          ░  ░     ░  ░  ░ ░           ░  ░     ░  ░ ░     ░ ░        ░      ░           ░           ░  ░  ░      ",
            @"    .                  ░                                  ░░ ░                                  +            +    ",
            @"                            .                *        .             +                                             ",
            @"                 *                                                               *                                ",
            @"     .                                                        *                                         .         ",
            @"                                      .                     *                                *                    ",
            @".                    *                            .                                                               ",
            @".                            *                                              +                          *          ",
            @"                                                         *                             .                          ",
            @"                     +                                            ,                                               ",
            @"         +                                  .       *                                               .             ",
            @"                                                                                             .                    ",
            @"___/\_____-^^-^--_______/\ /\---/\______ ____^/\___^--___/\_____-^^-^--_______/\ /\---/\___________---/\---_______",
            @"  --            --       __ _-  -    ---     /\^              ^      ^       ^        --       ^       ^      /\  ",
            @"        ___                                         --       __ _-                  ^                __       --  ",
            @"                   ___--  ^  ^                            --  __            ___--  ^  ^                /\^        ",
              
			};

		    Console.Clear();
		
		int topPosition = 2;

		foreach (string line in logoLines)
		{
		    Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
		    Console.WriteLine(line);
		    System.Threading.Thread.Sleep(50); 
		    topPosition++;
		}
		}
		public static void Start()
		{
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("Laz Labyrinth!");
			Console.Write("Enter your username: ");
			currentPlayer.name = Console.ReadLine();
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("Ten Years ago strange towers started appearing in different part of the world.");
			Console.WriteLine("One of the towers sprouted within your city, this prompted merchants seeking the opportunity to exploit the Dungeon as a business venture for would be adventurers.");
			Console.WriteLine("The people starter calling it Laz Labyrinth.");
			Console.WriteLine("it is said that those who clear the labyrinth will be given a power to rule over others but upto this day no one has ever cleared it.");
			Console.WriteLine("No one has ever comes back after entering the labyrinth.");
			Console.ReadKey();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("You want to conquer the labyrinth to build a country where no one is abused.");
			Console.WriteLine("The living conditions within the city of Rivia are subhuman.");
			Console.WriteLine("Trash and scum litters the backstreets, crime and thugs fills the back alleys. You wish to create a city where everyone can smile genuinely, and hopefully soon.");
			Console.ReadKey();
			Console.Clear();
			CmpltnLaz.PrintLogo4();
			Console.WriteLine("With the labyrinth in your city, the residents of Rivia flocked to beat the Labyrinth as to acquire the rumored power hidden within the Labyrinth.");
			Console.WriteLine("Your city encourages the city's residents to enter the Labyrinth with bounties as to incentivize the residents to take up arms. ");
			Console.WriteLine("You already made a few runs within the labyrinth, you already managed to glance on the hidden sceneries within the labyrinth with suprisingly having its own ecosystem maintaining a balance.");
			Console.WriteLine("You ventured to the entrance of the first floor, with your previous runs, you already know that your first mob will be a slime.");
			Console.ReadKey();
			Encounters.FirstEncounter();
		}
		static void DisplayAbout()
        {
            Console.Clear(); // Clear the console screen

            PrintLogo1();
            Console.Clear();
            CmpltnLaz.PrintLogo5();
            Console.WriteLine("Leader/Programmer: Aivan Wilfred Reyes");
            Console.WriteLine("Designer: Lawrence Dave Tolentino");
            Console.WriteLine("Writer/Editor: Zakari Seth Cuenca");
            Console.WriteLine("Welcome to Laz Labyrinth. ");
            Console.WriteLine("In this game, you take part in a story where mythical creatures dwell within a dungeon called LAZ LABYRINTH. ");
            Console.WriteLine("Tackle the various mobs and see how far you can go within the dungeon.");
            Console.WriteLine("Will you be the one who completes the dungeon, or will you be part of the various adventurers who becomes part of the dungeon and be lost through time. ");
            Console.WriteLine("Leaving a mark on the dungeon’s history as the adventurer who beats the dungeon, or another that fails its various test on the wills and skills of any adventurers who dares to venture within the confines of the dungeon’s various floors...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadKey();
            MainMenu();
            Console.ReadLine();
        }
		public static void Print2(string text, int speed = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
	}
}
