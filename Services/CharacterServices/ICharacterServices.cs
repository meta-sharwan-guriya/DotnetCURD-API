using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Dtos.Characters;

namespace RPG.Services.CharacterServices
{
    public interface ICharacterServices
    {
        public Task<ServicesResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newPlayer);

        public Task<ServicesResponse<GetCharacterDto>> GetCharacterById(int id);

        public Task<ServicesResponse<List<GetCharacterDto>>> GetAllCharacter();
    }
}