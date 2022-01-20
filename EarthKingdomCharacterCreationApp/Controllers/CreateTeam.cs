using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthKingdomCharacterCreationApp.Controllers
{
    public class CreateTeam
    {
        private List<Team> _teamDir = new List<Team>();

        public bool AddTeamToDir(Team team)
        {
            int teamId = _teamDir.Id;
            _teamDir.Add(team);
        }
    }
}