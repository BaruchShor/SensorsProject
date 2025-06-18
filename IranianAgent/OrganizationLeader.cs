using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class OrganizationLeader : Agent
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private static IranianAgentsTypes Type = IranianAgentsTypes.OrganizationLeader;

        private static int NumWeaknesses = 8;
        public OrganizationLeader(string name, int id) : base(name, id, Type, NumWeaknesses)
        {
            this.Name = name;
            this.Id = id;
        }

        public override (Sensor[], Sensor[]) Attack()
        {
            if(this.Counterattack % 3 == 0)
            {
                this.AttachingSensors[random.Next(this.AttachingSensors.Length)] = null;
            }else if(this.Counterattack % 10 == 0)
            {
                this.TypesOfWeaknesses = this.SticksSensors.SensorsCoupler();
                this.AttachingSensors = new Sensor[this.TypesOfWeaknesses.Length];
            }
            return (this.TypesOfWeaknesses, this.AttachingSensors);
        }
    }
}
