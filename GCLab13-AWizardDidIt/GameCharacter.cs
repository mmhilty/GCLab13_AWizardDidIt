using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13_AWizardDidIt
{
    class GameCharacter
    {
        protected string CharacterClass = "Mundane";
        protected string CharacterName;
        protected int CharIntel;
        protected int CharStrength;

        public GameCharacter(string characterName, int charIntel, int charStrength)
        {
            CharacterName = characterName;
            CharIntel = charIntel;
            CharStrength = charStrength;
        }

        public virtual string Play()
        {
            return ($"My name is {CharacterName} the {CharacterClass}.\n" +
                $"My intelligence level is {CharIntel} and my strength is {CharStrength}.");
        }

    }
}
