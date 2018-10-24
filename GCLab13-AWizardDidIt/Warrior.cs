using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13_AWizardDidIt
{
    class Warrior : GameCharacter
    {
        private new string CharacterClass = "Warrior";
        private string WeaponType;
        

        public Warrior(string characterName, int charIntel, int charStrength, string weaponType) : base (characterName, charIntel, charStrength)
        {

            WeaponType = weaponType;
        }

        public override string Play()
        {
            return ($"My name is {CharacterName} the {CharacterClass}.\n" +
                $"My intelligence level is {CharIntel} and my strength is {CharStrength}.\n" +
                $"I decimate my enemies with my {WeaponType}.");
        }
    }
}
