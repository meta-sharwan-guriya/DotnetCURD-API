using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services.CharacterServices
{
    public interface ICharacterServices
    {
        public Task<ServicesResponse<List<Character>>> AddCharacter(Character newPlayer);

        public Task<ServicesResponse<Character>> GetCharacterById(int id);

        public Task<ServicesResponse<List<Character>>> GetAllCharacter();
    }
}