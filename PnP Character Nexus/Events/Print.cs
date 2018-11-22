using PnP_Character_Nexus.Abstracts;
using PnP_Character_Nexus.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PnP_Character_Nexus.Events
{
    public class Print<TCharacter> : ICharacterVisitor<TCharacter> where TCharacter : Character
    {
        public void Visit(TCharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
