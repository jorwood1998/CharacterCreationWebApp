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
    public class TeamController : ApiController
    {
        private readonly TeamDBContext _team = new TeamDBContext();
        public CharacterDbContext _character = new CharacterDbContext();

        //CREATE
        [HttpPost]
        public async Task<IHttpActionResult> CreateTeam([FromBody] Team team)
        {
            if (team == null)
            {
                return BadRequest("Invalid");
            }
            if (ModelState.IsValid)
            {
                _team.Team.Add(team);
                int teamAmountChange = await _team.SaveChangesAsync();

                return Ok("Team add success");
            }
            //Invalid team
            return BadRequest(ModelState);
        }

        //READ
        //All Teams
        [HttpGet]
        public async Task<IHttpActionResult> ListTeams()
        {
            List<Team> teams = await _team.Team.ToListAsync();
            return Ok(teams);
        }
        //Search By Team Name
        [HttpGet]
        public async Task<IHttpActionResult> GetTeamByName([FromUri] string teamName)
        {
            Team character = await _team.Team.FindAsync(teamName);

            if (character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }
        //Search By Team ID
        [HttpGet]
        public async Task<IHttpActionResult> GetTeamById([FromUri] string teamId)
        {
            Team character = await _team.Team.FindAsync(teamId);

            if (character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }
        //UPDATE
        //add character to team
        [HttpGet]
        public async Task<IHttpActionResult> GetCharacterById([FromUri]int id)
        {
            CharacterCreate character = await _character.CharacterCreate.FindAsync(id);
            if (character != null)
            {
                return Ok(character);
            }

            return NotFound();
        }
        [HttpPut]
        public async Task<IHttpActionResult> UpdateTeam([FromUri] int TeamId, [FromBody] Team updatedTeam)
        {
            if (TeamId != updatedTeam?.TeamId)
            {
                return BadRequest("Ids do not match.");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            Team team = await _team.Team.FindAsync(TeamId);
            if (team is null)
            {
                return NotFound();
            }
            team.TeamMembers = updatedTeam.TeamMembers;
            team.TeamName = updatedTeam.TeamName;


            await _character.SaveChangesAsync();

            return Ok("The team has been updated");

        }
        [HttpPut]
        public async Task<IHttpActionResult> AddCharacterToTeam([FromUri] int id, [FromBody] Team teamId)
        {
            CharacterClass foundCharacter = await _character.CharacterClass.FindAsync(id);
            if (foundCharacter == null)
            {
                return NotFound();
            }
            

            Team foundTeam = await _team.Team.FindAsync(teamId);

            if (foundTeam == null)
            {
                return NotFound();
            }

            foundTeam.TeamMembers.Add(foundCharacter);

            return Ok($"{foundCharacter} added to {foundTeam}");

        }
        //REMOVE
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteTeam([FromUri] int id)
        {
            Team team = await _team.Team.FindAsync(id);
            if (team == null)
                return NotFound();

            _team.Team.Remove(team);

            await _character.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IHttpActionResult> RemoveCharacterFromTeam([FromUri] int id, [FromBody] Team teamId)
        {
            CharacterClass foundCharacter = await _character.CharacterClass.FindAsync(id);
            if (foundCharacter == null)
            {
                return NotFound();
            }


            Team foundTeam = await _team.Team.FindAsync(teamId);

            if (foundTeam == null)
            {
                return NotFound();
            }

            foundTeam.TeamMembers.Remove(foundCharacter);

            return Ok($"{foundCharacter} removed from {foundTeam}");

        }


    }
}
