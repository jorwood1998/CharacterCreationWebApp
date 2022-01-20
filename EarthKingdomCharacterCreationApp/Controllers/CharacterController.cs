using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EarthKingdomCharacterCreationApp.Controllers
{
    public class CharacterController : ApiController
    {
        private readonly CharacterDbContext _character = new CharacterDbContext();

        // POST (create)
        // api/Character
        [HttpPost]
        public async Task<IHttpActionResult> CreateCharacter([FromBody] Character character) 
        {
            if (character is null)
            {
                return BadRequest("Your request body cannot be empty.");
            }

            // If valid
            if(ModelState.IsValid)
            {
                // Store in the database
                _character.Characters.Add(character);
                int changeCount = await _character.SaveChangesAsync();

                return Ok("Welcome, your challenge awaits!");
            }

            // The character is not valid, go ahead and reject it
            return BadRequest(ModelState);
        }

        // GET ALL
        // api/Character
        [HttpGet]
        public async Task<IHttpActionResult> GetCharacters()
        {
            List<Character> characters = await _character.Characters.ToListAsync();
            return Ok(characters);
        }

        // GET BY NAME
        // api/Character/{Name}
        [HttpGet]
        public async Task<IHttpActionResult> GetCharacterByName([FromUri]string name)
        {
            Character character = await _character.Characters.FindAsync(name);

            if(character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }
        //Get by attribute
        [HttpGet]
        public async Task<IHttpActionResult> GetCharacterByAttribute([FromUri]string attribute)
        {
            Character character = await _character.Characters.FindAsync(attribute);
            if (character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }
    }

}

