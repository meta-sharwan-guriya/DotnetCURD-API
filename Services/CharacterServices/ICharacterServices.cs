using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services.CharacterServices
{
    public interface ICharacterServices
    {
        public Task<List<Character>> AddCharacter(Character newPlayer);

        public Task<Character> GetCharacterById(int id);

        public Task<List<Character>> GetAllCharacter();
    }
}