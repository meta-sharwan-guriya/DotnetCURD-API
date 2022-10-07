using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RPG.Dtos.Characters;

namespace RPG.Services.CharacterServices
{
    public class CharacterServices : ICharacterServices
    {
        private readonly IMapper _mapper;

        public CharacterServices(IMapper mapper)
        {
            _mapper = mapper;
            
        }
         public static List<Character> player = new List<Character>{
            new Character(),
            new Character{Name="Sam"}
        };
        public async Task<ServicesResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newPlayer)
        {
            var servicesResponse=new ServicesResponse<List<GetCharacterDto>>();
            player.Add(_mapper.Map<Character> (newPlayer));
            servicesResponse.Data=player.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();
            return  servicesResponse;
        }

        public async Task<ServicesResponse<List<GetCharacterDto>>> GetAllCharacter()
        {
           return new ServicesResponse<List<GetCharacterDto>>{Data=player.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList()};
        }

        public async Task<ServicesResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var servicesResponse=new ServicesResponse<GetCharacterDto>();
            var character=player.FirstOrDefault(p => p.Id == id);
            servicesResponse.Data=_mapper.Map<GetCharacterDto>(character);
            return servicesResponse;
        }
    }
}