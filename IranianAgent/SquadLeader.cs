using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SquadLeader : Agent
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private static IranianAgentsTypes Type = IranianAgentsTypes.SquadLeader;

        private static int NumWeaknesses = 4;
        public SquadLeader(string name, int id) : base(name, id, Type, NumWeaknesses)
        {
            this.Name = name;
            this.Id = id;
        }

        public override (Sensor[], Sensor[]) Attack()
        {
            if (this.Counterattack % 3 == 0)
            {
                this.AttachingSensors[random.Next(this.AttachingSensors.Length)] = null;
            }
            return (this.TypesOfWeaknesses, this.AttachingSensors);
        }
    }
}
