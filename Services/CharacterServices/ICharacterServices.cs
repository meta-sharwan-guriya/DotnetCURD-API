using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services.CharacterServices
{
    public interface ICharacterServices
    {
        public List<Character> AddCharacter(Character newPlayer);

        public Character GetCharacterById(int id);

        public List<Character> GetAllCharacter();
    }
}