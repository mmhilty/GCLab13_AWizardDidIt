using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13_AWizardDidIt
{
    class MagicUsingCharacter : GameCharacter
    {
        private new string CharacterClass = "Magic User";
        protected int MagicalEnergy;

        public MagicUsingCharacter(string characterName, int charIntel, int charStrength, int magicalEnergy) : base(characterName, charIntel, charStrength)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override string Play()
        {
            return ($"My name is {CharacterName} the {CharacterClass}.\n" +
                $"My intelligence level is {CharIntel} and my strength is {CharStrength}.\n" +
                $"I have so much Magickal Energism. In fact, I have {MagicalEnergy} levels in it.");
        }

    }
}
