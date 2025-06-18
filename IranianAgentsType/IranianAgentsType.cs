using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class IranianAgentsType
    {
        public enum IranianAgentsTypes
        {
            FootSoldier,
            OrganizationLeader,
            SeniorCommander,
            SquadLeader
        }

        public Dictionary<IranianAgentsTypes, Func<string, int,Agent>> AgentsCreaterDict = new Dictionary<IranianAgentsTypes, Func<string, int, Agent>>
        {
            { IranianAgentsTypes.FootSoldier,(name,id) => new FootSoldier(name,id)},
            { IranianAgentsTypes.OrganizationLeader,(name,id) => new OrganizationLeader(name,id)},
            { IranianAgentsTypes.SeniorCommander,(name,id) => new SeniorCommander(name,id)},
            { IranianAgentsTypes.SquadLeader,(name,id) => new SquadLeader(name,id)}
        };

        public Dictionary<int, IranianAgentsTypes> KeyTypesWords = new Dictionary<int, IranianAgentsTypes>
        {
            {1, IranianAgentsTypes.FootSoldier },
            {2, IranianAgentsTypes.SquadLeader },
            {3, IranianAgentsTypes.SeniorCommander },
            {4, IranianAgentsTypes.OrganizationLeader}
        };
    }
}
