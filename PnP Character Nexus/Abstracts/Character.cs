using PnP_Character_Nexus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnP_Character_Nexus.Abstracts
{
    public abstract class Character
    {
        public abstract string Name { get; set; }
        public abstract Ruleset Ruleset { get; set; }
        public abstract void Accept(ICharacterVisitor visitor);
    }
}
