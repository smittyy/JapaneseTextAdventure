using System;
using System.Collections.Generic;
using System.Text;

namespace Text_based_Game
{
    public class Class1
    {
        public string name;
        public string playerClass;
        public string playerLover;

    public void Greeting()
        {
            switch (playerClass)
            {
                case "ashigaru":
                    Console.WriteLine($"After training you body and mind for years you are the strongest warrior in your village. You are the Ashigaru!");
                    Console.WriteLine();
                    break;
                case "ninja":
                    Console.WriteLine($"The most cunning thief and skilled assasian around. Although no one knows about you, because you are the best Ninja.");
                    Console.WriteLine();
                    break;
                case "archer":
                    Console.WriteLine($"From afar you smite your enemies with a hail of arrows. Peircing the hardest of armor, you are the Archer!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("sorry but that is not a class. Please pick again or restart the game.");
                    Console.WriteLine();
                    Program.CharacterCreation();
                    break;
            }
        }
    }
}
