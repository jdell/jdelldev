using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Team:Member
    {
        public Team()
        {
            this.Type = tMEMBER.TEAM;
        }

        List<Player> _players = new List<Player>();

        public List<Player> Players
        {
            get { return _players; }
        }

    }
}
