using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Text_based_Game
{
    class Class2PartOne
    {

        public static void TownOfBeginings()
        {
            Console.Clear();
            Console.WriteLine("You wake up in a pile of dung and straw. As soon as you wake up you are assualted with the smell of smoke rather than S**t. Your head is killing you and you can quite figure out which way is up or down.");
            Console.WriteLine();

            Console.WriteLine("As you come more to your senses you start to take in your surroundings a little bit better. What would you like to do?");
            Console.WriteLine("__________________________________________________________________________________________________________");
            Console.WriteLine("1) look around");
            Console.WriteLine("2) stand up");
            Console.WriteLine("3) push your face deeper into the pile of crap");
            Console.WriteLine("__________________________________________________________________________________________________________");
            int classTwoWhileLoopOne = 0;
            while (classTwoWhileLoopOne < 1)
            {
                string shitChoiceOne = Console.ReadLine();
                switch (shitChoiceOne)
                {
                    case "1":
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        ShitChoiceOneDashOne();
                        classTwoWhileLoopOne++;
                        break;
                    case "2":
                        classTwoWhileLoopOne++;
                        break;
                    case "3":
                        classTwoWhileLoopOne++;
                        break;
                    default:
                        Console.WriteLine("Im sorry but that is not a choice that you have right now. Please try again.");
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        break;

                }
            }
        }

            //This belongs to Town of Beginings
            static void ShitChoiceOneDashOne()
            {
                Console.WriteLine("As you take a closer look around you can see that you're in a barn that is burning down. Your heart speeds up as you start to take in the severity of your situation. You dont have too much time to think though. As you lay there in the shit a massive piece of burning timber falls next to you.");
                Console.WriteLine();
                Console.WriteLine("Please hurry and decide what you next action will be. Unless you are too scared to move.");
                Console.WriteLine();
                Console.WriteLine("1) look around");
                Console.WriteLine("2) stand up");
                Console.WriteLine("3) Cry yourself to sleep");
                Console.WriteLine("__________________________________________________________________________________________________________");

            int classTwoWhileLoopOne = 0;
            while (classTwoWhileLoopOne < 1)
            {
                string shitChoiceOne = Console.ReadLine();
                switch (shitChoiceOne)
                {
                    case "1":
                        ShitChoiceOneDashOneDashOne();
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        classTwoWhileLoopOne++;
                        break;
                    case "2":
                        classTwoWhileLoopOne++;
                        break;
                    case "3":
                        ShitChoiceOneDashOneDashThree();
                        classTwoWhileLoopOne++;
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        break;
                    default:
                        Console.WriteLine("Im sorry but that is not a choice that you have right now. Please try again.");
                        Console.WriteLine("__________________________________________________________________________________________________________");
                        break;

                }
            }
        }
             //This belongs to Town of Beginings
             static void ShitChoiceOneDashTwo()
            {
            Console.WriteLine("You quickly jump to your feet out of reflex. You stuble a little as your feet sink into the dung beneath your feet. No matter though shoes are less inportant than your life. Which is quickly put in danger as you begin to heat up.");
            Console.WriteLine();
            Console.WriteLine("1) look around");
            Console.WriteLine("2) Do a little jig");
            Console.WriteLine("__________________________________________________________________________________________________________");
            }
             //This belongs to Town of Beginings
             static void ShitChoiceOneDashThree()
            {
            Console.WriteLine("You push your face into the straw and feel a uneasy but warm feeling wash over you.");
            Console.WriteLine();
            Console.WriteLine("1) Take your face out");
            Console.WriteLine("2) Push deeper");
            Console.WriteLine("__________________________________________________________________________________________________________");
            }

        //ShitChoiceOneDashOne 1) Look Around
        static void ShitChoiceOneDashOneDashOne()
        {
            Console.Clear();
            Console.WriteLine("You find your situation so hard to believe that you are in shock. The building you are in is mostly charcoal and red embers. Amazingly however the roof manages to stand tall above you, though it wont last forever. Now more than anytime you should snap out of it and will yourself through.");
            Console.WriteLine();
            Console.WriteLine("1) Look around");
            Console.WriteLine("2) Stand up");
            Console.WriteLine("__________________________________________________________________________________________________________");
        }

        //ShitChoiceOneDashOne 3) Cry yourself to sleep
        static void ShitChoiceOneDashOneDashThree()
        {
            Program.causeOfDeat = "You Died In your Sleep to a fire";
            Console.Clear();
            Program.DeathScreen();
        }
    }
}
