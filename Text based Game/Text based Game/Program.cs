using System;

namespace Text_based_Game
{
    class Program
    {
        public static int partOneWhileLoop = 0;
        public static string causeOfDeat = "";
        static void Main(string[] args)
        {
            Intro();
        }

        public static void Intro()
        {
            Console.WriteLine("This game is a first for the developer and will ask specific inputs from the player. Most often the player should deafult to \"Y\" or \"N\" when asked yes or no questions");
            Console.WriteLine("Welcome to Toraberu. This is a game made to tell the story of a young boy making his way to the castle of the local lord to win back the love of his life who was stolen from him. The journey will be long and hard. Are you prepared for the hurdles that you must overcome?");
            Console.WriteLine("__________________________________________________________________________________________________________");

            string beginTheGame = Console.ReadLine().ToLower();
            switch (beginTheGame)
            {
                case "y":
                    Console.WriteLine("Well thats Great then we'll get right into the action. Let's GO!!");
                    Console.WriteLine("__________________________________________________________________________________________________________");
                    CharacterCreation();
                    break;
                case "n":
                    Console.WriteLine("I guess thats too bad. But dont worry, there is always next time.");
                    Console.WriteLine("__________________________________________________________________________________________________________");
                    break;
                default:
                    Console.WriteLine("Im sorry but that input does not make sense to me. Please press \"Enter\" to try agian.");
                    Console.ReadLine();
                    Console.WriteLine("__________________________________________________________________________________________________________");
                    Intro();
                    break;
            }
        }

        public static void CharacterCreation()
        {
            Class1 playersActualCharacter = new Class1();
            Console.WriteLine("What is your name?");
            playersActualCharacter.name = Console.ReadLine();
            Console.WriteLine("__________________________________________________________________________________________________________");
            Console.WriteLine("Great now please pick a class. You may choose from a mighty \"Ashigaru\", a sneaky \"Ninja\", or an eagle eye \"Archer\"");
            playersActualCharacter.playerClass = Console.ReadLine().ToLower();
            Console.WriteLine("__________________________________________________________________________________________________________");
            playersActualCharacter.Greeting();
            Console.WriteLine("Last is to pick the name of your love intrest who was stolen from you.");
            playersActualCharacter.playerLover = Console.ReadLine();
            Console.WriteLine("__________________________________________________________________________________________________________");

            while (partOneWhileLoop < 1)
            {
                Console.WriteLine($"You are {playersActualCharacter.name} a proud {playersActualCharacter.playerClass} who is on a mission to save {playersActualCharacter.playerLover}, your soon to be wife from the Lord of this land. Is that all correct?");
                

                string startCorrectQ = Console.ReadLine().ToLower();
                switch (startCorrectQ)
                {
                    case "y":
                        Console.WriteLine("Good then we can move on.");
                        partOneWhileLoop++;
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        Class2PartOne.TownOfBeginings();
                        break;
                    case "n":
                        Console.WriteLine("Then feel free to try again.");
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        CharacterCreation();
                        break;
                    default:
                        Console.WriteLine("Im sorry but that input does not make sense to me. Please press \"Enter\" to try agian.");
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        Console.ReadLine();
                        break;
                       
                }
            }
        }

        public static void DeathScreen()
        {
            Console.WriteLine("__________________________________________________________________________________________________________");
            Console.WriteLine("                                          YOU DIED");
            Console.WriteLine("__________________________________________________________________________________________________________");
        }
    }
}