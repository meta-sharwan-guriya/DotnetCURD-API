using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        public static List<Character> player = new List<Character>{
            new Character(),
            new Character{Name="Sam"}
        };

        [HttpGet]
        [Route("GetAll")]        // [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(player);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(player.FirstOrDefault(p => p.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> post(Character newPlayer){
            player.Add(newPlayer);
            return Ok(player);
        }
    }
}