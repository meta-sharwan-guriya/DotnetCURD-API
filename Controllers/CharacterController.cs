using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Services.CharacterServices;
using Microsoft.AspNetCore.Mvc;
using RPG.Dtos.Characters;

namespace RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterServices _context;

        public CharacterController(ICharacterServices context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAll")]        // [HttpGet("GetAll")]
        public async Task<ActionResult<ServicesResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _context.GetAllCharacter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServicesResponse<GetCharacterDto>>> Get(int id)
        {
            return Ok(await _context.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServicesResponse<List<GetCharacterDto>>>> post(AddCharacterDto newPlayer)
        {
            return Ok(await _context.AddCharacter(newPlayer));
        }
    }
}