using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13_AWizardDidIt
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5] {(new Wizard("Rincewind", 10, 2, 39, "Escape")) ,
                new Wizard("Sparky Magicboots", 10, 2, 39, "Magic Missile"),
                new Wizard("Bluebell Hexwood",22, 15, 9001,"Vine Whip"),
                new Warrior("Big McLargeHuge", 5, 22, "BigMcLargeAxe"),
                new Warrior("Thorvald Strongthews", 8, 30, "Foehammer") } ;

            foreach (GameCharacter character in gameCharacters)
            {
                Console.WriteLine(character.Play() + "\n");
            }

        }
    }
}
