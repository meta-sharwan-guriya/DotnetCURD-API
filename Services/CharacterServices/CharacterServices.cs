using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services.CharacterServices
{
    public class CharacterServices : ICharacterServices
    {

         public static List<Character> player = new List<Character>{
            new Character(),
            new Character{Name="Sam"}
        };
        public async Task<ServicesResponse<List<Character>>> AddCharacter(Character newPlayer)
        {
            var servicesResponse=new ServicesResponse<List<Character>>();
            player.Add(newPlayer);
            servicesResponse.Data=player;
            return  servicesResponse;
        }

        public async Task<ServicesResponse<List<Character>>> GetAllCharacter()
        {
           return new ServicesResponse<List<Character>>{Data=player};
        }

        public async Task<ServicesResponse<Character>> GetCharacterById(int id)
        {
            var servicesResponse=new ServicesResponse<Character>();
            var character=player.FirstOrDefault(p => p.Id == id);
            servicesResponse.Data=character;
            return servicesResponse;
        }
    }
}