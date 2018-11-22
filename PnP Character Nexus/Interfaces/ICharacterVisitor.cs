using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnP_Character_Nexus.Interfaces
{
    public interface ICharacterVisitor<TCharacter> : ICharacterVisitor
    {
        void Visit(TCharacter character);
    }

    public interface ICharacterVisitor { }
}
