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
        public async Task<List<Character>> AddCharacter(Character newPlayer)
        {
            player.Add(newPlayer);
            return player;
        }

        public async Task<List<Character>> GetAllCharacter()
        {
           return player;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return (player.FirstOrDefault(p => p.Id == id));
        }
    }
}