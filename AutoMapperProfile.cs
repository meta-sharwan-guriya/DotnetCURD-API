using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RPG.Dtos.Characters;

namespace DotnetCURD_API
{
    public class AutoMapperProfile: Profile
    {
     public AutoMapperProfile()
     {
        CreateMap<Character,GetCharacterDto>();
     }   
    }
}