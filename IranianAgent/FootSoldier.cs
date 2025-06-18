using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class FootSoldier : Agent
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private static IranianAgentsTypes Type = IranianAgentsTypes.FootSoldier;

        private static int NumWeaknesses = 2;
        public FootSoldier(string name, int id) : base(name, id, Type, NumWeaknesses)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
