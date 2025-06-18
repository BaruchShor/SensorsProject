using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SeniorCommander : Agent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int FirstRandom { get; set; }

        private static IranianAgentsTypes Type = IranianAgentsTypes.SeniorCommander;

        private static int NumWeaknesses = 6;
        public SeniorCommander(string name, int id) : base(name, id, Type, NumWeaknesses)
        {
            this.Name = name;
            this.Id = id;
        }

        public override (Sensor[], Sensor[]) Attack()
        {
            int secondRandom;
            this.FirstRandom = random.Next(this.AttachingSensors.Length);
            if (this.Counterattack % 3 == 0)
            {
                this.AttachingSensors[this.FirstRandom] = null;
                do
                {
                    secondRandom = random.Next(this.AttachingSensors.Length);
                } while (secondRandom == this.FirstRandom);
                this.AttachingSensors[secondRandom] = null;
            }
            return (this.TypesOfWeaknesses, this.AttachingSensors);
        }
    }
}
