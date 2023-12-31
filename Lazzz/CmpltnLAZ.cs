using System;

namespace LazLabyrinth
{
    class CmpltnLaz
    {	
//        public static void MainMenu()
//        {	
//           while (true)	
//            {           	
//                PrintLogo1(); // Display the logo at the top and centered
//                
//                // Display the menu in the middle of the console window
//                int menuTopPosition = Console.WindowHeight / 2 + 2; // Increase this value to move the menu further down
//                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition);
//                Print2("Main Menu:");
//                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 1);
//                Print2("1. Start Game");
//                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 2);
//                Print2("2. About");
//                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, menuTopPosition + 3);
//                Print2("3. Exit");
//                ConsoleKeyInfo keyInfo = Console.ReadKey();
//				
//                switch (keyInfo.Key)
//                {
//                    case ConsoleKey.D1:
//                		Gamestarts();
//                        break;
//                    case ConsoleKey.D2:
//                        DisplayAbout();
//                        break;
//                    case ConsoleKey.D3:
//                        return;
//                    default:
//                        Console.WriteLine("Error!Please press a key between 1 and 3.");
//                        Console.ReadLine(); // Pause to let the user read the message
//                        break;
//                }
//            }
//        }
//
//        static void PrintLogo1()
//{
//    // Display the ASCII art logo at the top center of the console window
//    string[] logoLines = {
//            @"      .                                                                            .                          +   ",
//            @"           .                                    +                                          .                      ",
//            @"   +   ██▓    ▄▄▄  *   ▒███████▒    ██▓    ▄▄▄       ▄▄▄▄ ▓██   ██▓ ██▀███   ██▓ ███▄ +  █ ▄▄▄█████▓ ██░ ██       ",
//            @"      ▓██▒   ▒████▄    ▒ ▒ ▒ ▄▀░   ▓██▒   ▒████▄    ▓█████▄▒██  ██▒▓██ ▒ ██▒▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓██░ ██▒  *   ",
//            @"      ▒██░   ▒██  ▀█▄  ░ ▒ ▄▀▒░    ▒██░   ▒██  ▀█▄  ▒██▒ ▄██▒██ ██░▓██ ░▄█ ▒▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░▒██▀▀██░      ",
//            @"  *   ▒██░   ░██▄▄▄▄██   ▄▀▒   ░   ▒██░   ░██▄▄▄▄██ ▒██░█▀  ░ ▐██▓░▒██▀▀█▄  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ░▓█ ░██       ",
//            @"      ░██████▒▓█   ▓██▒▒███████▒   ░██████▒▓█   ▓██▒░▓█  ▀█▓░ ██▒▓░░██▓ ▒██▒░██░▒██░   ▓██░  ▒██▒ ░ ░▓█▒░██▓      ",
//            @"      ░ ▒░▓  ░▒▒   ▓▒█░░▒▒ ▓░▒░▒   ░ ▒░▓  ░▒▒   ▓▒█░░▒▓███▀▒ ██▒▒▒ ░ ▒▓ ░▒▓░░▓  ░ ▒░   ▒ ▒   ▒ ░░    ▒ ░░▒░▒      ",
//            @"      ░ ░ ▒  ░ ▒   ▒▒ ░░░▒ ▒ ░ ▒   ░ ░ ▒  ░ ▒   ▒▒ ░▒░▒   ░▓██ ░▒░   ░▒ ░ ▒░ ▒ ░░ ░░   ░ ▒░    ░     ▒ ░▒░ ░      ",
//            @"        ░ ░    ░   ▒   ░ ░ ░ ░ ░     ░ ░    ░   ▒    ░    ░▒ ▒ ░░    ░░   ░  ▒ ░   ░   ░ ░   ░       ░  ░░ ░      ",
//            @"          ░  ░     ░  ░  ░ ░           ░  ░     ░  ░ ░     ░ ░        ░      ░           ░           ░  ░  ░      ",
//            @"    .                  ░                                  ░░ ░                                  +            +    ",
//            @"                            .                *        .             +                                             ",
//            @"                 *                                                               *                                ",
//            @"     .                                                        *                                         .         ",
//            @"                                      .                     *                                *                    ",
//            @".                    *                            .                                                               ",
//            @".                            *                                              +                          *          ",
//            @"                                                         *                             .                          ",
//            @"                     +                                            ,                                               ",
//            @"         +                                  .       *                                               .             ",
//            @"                                                                                             .                    ",
//            @"___/\_____-^^-^--_______/\ /\---/\______ ____^/\___^--___/\_____-^^-^--_______/\ /\---/\___________---/\---_______",
//            @"  --            --       __ _-  -    ---     /\^              ^      ^       ^        --       ^       ^      /\  ",
//            @"        ___                                         --       __ _-                  ^                __       --  ",
//            @"                   ___--  ^  ^                            --  __            ___--  ^  ^                /\^        ",
//              
//			};
//
//    Console.Clear();
//
//int topPosition = 2;
//
//foreach (string line in logoLines)
//{
//    Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
//    Console.WriteLine(line);
//    System.Threading.Thread.Sleep(50); 
//    topPosition++;
//}
//        }
    

//
//        static void Gamestarts()
//        {
//        	Console.Clear();
//        	Print2("Welcome to Laz Labyrinth Adventurers!");
//            Console.ReadKey();
//        }

//        static void DisplayAbout()
//        {
//            Console.Clear(); // Clear the console screen
//
//            PrintLogo1();
//            
//            Print2("Zakarizz");
//            Print2("Aivanrizz");
//            Print2("Lawrizz");
//            Console.WriteLine("");
//            Console.WriteLine("");
//            Console.WriteLine("");
//            Console.WriteLine("");
//
//            Console.WriteLine("Press Enter to return to the main menu.");
//            Console.ReadLine();
//        }
        public static void Print2(string text, int speed = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        public static void PrintLogo2()
{
    // Display the ASCII art logo at the top center of the console window
    string[] logoLines = {
            @"               +      ▄████  ▄▄▄   +   ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███              *        ",
            @"     +      .        ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒       .             ",
            @"                    ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   +  ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒                     ",
            @"           .        ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄                       ",
            @"                    ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒               +     ",
            @"   .   (_)     +     ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░   +      *          ",
            @"       |=|            ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░                     ",
            @" +     |=|          ░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░                      ",
            @"   /|__|_|__|\            ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░                      +   ",
            @"  (    ( )    )                                                          ░                                        ",
            @"   \|\/\*/\/|/                          +                   .                                            .        ",
            @"     |  Y  |              *                                                           .                           ",
            @"     |  |  |                                                         +                                            ",
            @" *   |  |  |                                                                                      *               ",
            @"    _|  |  |                                            *                        *                                ",
            @" __/ |  |  |\                              .                                                             .        ",
            @"/  \ |  |  |  \                                                      .                        .                   ",
            @"   __|  |  |   |               *                                                                                  ",
            @"/\/  |  |  |   |\	                                                                   *                            ",
            @" <   +\ |  |\ />  \                                                                                     *         ",
            @"  >   + \  | LJ    |     .              +                *               .                                        ",
            @"        + \|+  \  < \                                                                              .              ",
            @"  (O)      +    |    )                                                                 +                     *    ",
            @"   |             \  /\ _/\ /\---/\______ ____^/\___^--___/\_____-^^-^--_______/\ /\---/\___________---/\---_______",
            @" ( | )   (o)      \/  )  __ _-  -    ---     /\^              ^      ^       ^        --       ^       ^      /\  ",
            @"_\\|//__( | )______)_/                              --       __ _-                  ^                __       --  ",
            @"        \\|//          -  ^  ^                            --  __            ___--  ^  ^                /\^        ",
            
			};

    Console.Clear();

    int topPosition = 1;

    foreach (string line in logoLines)
    {
       Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
       Console.WriteLine(line);
       System.Threading.Thread.Sleep(50); 
       topPosition++;
    }
    Console.ReadKey();
}
         public static void PrintLogo3()
{
    // Display the ASCII art logo at the top center of the console window
    string[] logoLines = {
@"                                                                                                                  ",
@"   .                                                                              .                               ",
@"	       +                 +                        *                                           +       .         ",
@"                                          +                       +                                               ",
@"                  *   ██▓     ▒█████   ▄▄▄      ▓█████▄  ██▓ ███▄    █   ▄████             .                      ",
@"                     ▓██▒    ▒██▒  ██▒▒████▄    ▒██▀ ██▌▓██▒ ██ ▀█   █  ██▒ ▀█▒                                   ",
@"                     ▒██░    ▒██░  ██▒▒██  ▀█▄  ░██   █▌▒██▒▓██  ▀█ ██▒▒██░▄▄▄░      +                            ",
@"              .      ▒██░    ▒██   ██░░██▄▄▄▄██ ░▓█▄   ▌░██░▓██▒  ▐▌██▒░▓█  ██▓                         *         ",
@"    +                ░██████▒░ ████▓▒░ ▓█   ▓██▒░▒████▓ ░██░▒██░   ▓██░░▒▓███▀▒ ██▓  ██▓  ██▓                     ",
@"                     ░ ▒░▓  ░░ ▒░▒░▒░  ▒▒   ▓▒█░ ▒▒▓  ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒  ▒▓▒  ▒▓▒  ▒▓▒                     ",
@"                     ░ ░ ▒  ░  ░ ▒ ▒░   ▒   ▒▒ ░ ░ ▒  ▒  ▒ ░░ ░░   ░ ▒░  ░   ░  ░▒   ░▒   ░▒          .           ",
@"                       ░ ░   ░ ░ ░ ▒    ░   ▒    ░ ░  ░  ▒ ░   ░   ░ ░ ░ ░   ░  ░    ░    ░                       ",
@"           .    +       ░  ░    ░ ░        ░  ░   ░     ░       *    ░       ░   ░    ░    ░     +                ",
@"                                         +       ░                               ░    ░    ░           .          ",
@"                  ,_._._._._._._._._|__________________________________________________________                   ",
@"      .           |_|_|_|_|_|_|_|_|_|_________________________________________________________/                   ",
@"                                    !	                                                                            ",
@"                                     GameDev: Always upgrade your stats.                            +             ",
@"  +                                     .                 .                             +                      *  ",
@"                                                                                                     *            ",
@"               +         .        .                                             .                                 ",
@"      .                                               .                                                           ",
@"                                        +                      +                           +                      ",
@"	                                                                    .                                           ",
@"                        +                       *                                                   +             ",
@"                                                                                                                  ",
@"   *                                   .                    .                       +                             ",
          
    };

    Console.Clear();

    int topPosition = 1;

foreach (string line in logoLines)
{
    Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
    Console.WriteLine(line);
    System.Threading.Thread.Sleep(45); 
    topPosition++;
}
        }
         public static void PrintLogo5()
{
    // Display the ASCII art logo at the top center of the console window
    string[] logoLines = {

            @"                  ,_._._._._._._._._|__________________________________________________________                   ",
			@"      .           |_|_|_|_|_|_|_|_|_|_________________________________________________________/                   ",
			@"                                                  THANK YOU!!                                                     ",
            @"         +                                  .       *                                               .             ",
            @"                                                                                             .                    ",
            @"___/\_____-^^-^--_______/\ /\---/\______ ____^/\___^--___/\_____-^^-^--_______/\ /\---/\___________---/\---_______",
            @"  --            --       __ _-  -    ---     /\^              ^      ^       ^        --       ^       ^      /\  ",
            @"        ___                                         --       __ _-                  ^                __       --  ",
            @"                   ___--  ^  ^                            --  __            ___--  ^  ^                /\^        ",

    };

    Console.Clear();

    int topPosition = 0;

    foreach (string line in logoLines)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
        Console.WriteLine(line);
        topPosition++;
    }
}
          public static void Print3(string text, int speed = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.ReadKey();
        }
          public static void PrintLogo4()
{
    // Display the ASCII art logo at the top center of the console window
    string[] logoLines = {

            @"                                                                                                                  ",
			@"                                 .  _____  .----------------------------. _____ .                                 ",
			@"   _____________________       .'  |     |  '.         L A Z         .'  |  _  |  '.     | Press (A) to Attack |  ",
			@"  |Run will go to       |     / ___| /|\ |___ \                     / ___| /A\ |___ \     ---------------------   ",
			@"  |__the shop___________|    : |      |      | :  __           __  : | _         _ | :   | Press (D) to Defend |  ",
			@"   _____________________     | | <---   ---> | | |__|         |__| | ||D|       (H)| |    ---------------------   ",
			@"  |                     |    : |___   |   ___| :SELECT       START : |___       ___| :   | Press (H) to Heal   |  ",
			@"  |_____________________|     \    | \|/ |    /  _      ___     _   \    | (R) |    /     ---------------------   ",
			@"                               '.  |_____|  .'         |___|         '.  |_____|  .'     | Press (R) to Run    |  ",
			@"                                 ' ------- '                           ' ------- '                                ",
            @"         +                                  .       *                                               .             ",
            @"                                                                                             .                    ",
            @"___/\_____-^^-^--_______/\ /\---/\______ ____^/\___^--___/\_____-^^-^--_______/\ /\---/\___________---/\---_______",
            @"  --            --       __ _-  -    ---     /\^              ^      ^       ^        --       ^       ^      /\  ",
            @"        ___                                         --       __ _-                  ^                __       --  ",
            @"                   ___--  ^  ^                            --  __            ___--  ^  ^                /\^        ",

    };

    Console.Clear();

    int topPosition = 0;

    foreach (string line in logoLines)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - line.Length / 2, topPosition);
        Console.WriteLine(line);
        topPosition++;
    }
}
          public static void Print(string text, int speed = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.ReadKey();
        }
     
        
        
        
        
        
	}
}