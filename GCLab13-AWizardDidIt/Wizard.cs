using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13_AWizardDidIt
{
    class Wizard : MagicUsingCharacter
    {
        private new string CharacterClass = "Wizard";
        private string WizardSpell;

        public Wizard(string characterName, int charIntel, int charStrength, int magicalEnergy, string wizardSpell) : base(characterName, charIntel, charStrength, magicalEnergy)
        {
            WizardSpell = wizardSpell;
        }

        public override string Play()
        {
            return ($"My name is {CharacterName} the {CharacterClass}.\n" +
                $"My intelligence level is {CharIntel} and my strength is {CharStrength}.\n" +
                $"I can cast my favorite spell {WizardSpell} with my level {MagicalEnergy} Magickal Energism.");
        }


    }
}
