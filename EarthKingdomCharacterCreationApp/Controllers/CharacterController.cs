using EarthKingdomCharacterCreationApp.Models;
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
        public async Task<IHttpActionResult> CreateCharacter([FromBody] CharacterCreate model) 
        {
            if (model is null)
            {
                return BadRequest("Your request body cannot be empty.");
            }

            // If valid
            if(ModelState.IsValid)
            {
                // Store in the database
                _character.CharacterCreate.Add(model);
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
            List<CharacterCreate> characters = await _character.CharacterCreate.ToListAsync();
            return Ok(characters);
        }

        // GET BY NAME
        // api/Character/{Name}
        [HttpGet]
        public async Task<IHttpActionResult> GetCharacterByName([FromUri]string name)
        {
            CharacterCreate character = await _character.CharacterCreate.FindAsync(name);

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

        // GET BY ID
        // api/Character/{id}
        [HttpGet]
        public async Task<IHttpActionResult> GetById([FromUri]int id)
        {
            CharacterCreate character = await _character.CharacterCreate.FindAsync(id);

            if(character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }

        // Put (update)
        // api/Character/{id}
        [HttpPut]
        public async Task<IHttpActionResult> UpdateCharacter([FromUri] int id, [FromBody] CharacterCreate updatedCharacter)
        {
            // check the ids if they match
            if(id != updatedCharacter?.Id)
            {
                return BadRequest("Ids do not match.");
            }

            // Check 
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Find the character in the database
            CharacterCreate character = await _character.CharacterCreate.FindAsync(id);

            // If the character doesn't exist...
            if (character is null)
                return NotFound();

            // Update the properties
            character.Strength = updatedCharacter.Strength;
            character.Dexterity = updatedCharacter.Dexterity;
            character.Constitution = updatedCharacter.Constitution;
            character.Intelligence = updatedCharacter.Intelligence;
            character.Wisdom = updatedCharacter.Wisdom;
            character.Charisma = updatedCharacter.Charisma;
            character.FirstName = updatedCharacter.FirstName;
            character.LastName = updatedCharacter.LastName;
            character.Alias = updatedCharacter.Alias;
            character.Height = updatedCharacter.Height;
            character.Build = updatedCharacter.Build;
            character.HairStyle = updatedCharacter.HairStyle;
            character.HairColor = updatedCharacter.HairColor;
            character.EyeColor = updatedCharacter.EyeColor;
            character.SkinColor = updatedCharacter.SkinColor;
            character.SpecialItems = updatedCharacter.SpecialItems;

            // Save the changes
            await _character.SaveChangesAsync();

            return Ok("Your character has been updated!");
        }

        // DELETE
        // api/Character/{id}
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteCharacter([FromUri] int id)
        {
            CharacterCreate character = await _character.CharacterCreate.FindAsync(id);

            if (character is null)
                return NotFound();

            _character.CharacterCreate.Remove(character);

            if(await _character.SaveChangesAsync() == 1)
            {
                return Ok("The character was deleted.");
            }

            return InternalServerError();
        }
    }

}

