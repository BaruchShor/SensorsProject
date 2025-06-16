using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class IAgent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Sensor> TypesOfWeaknesses { get; set; }
        public Dictionary<Sensor, int> SensorsDict { get; set; }

        public bool Activate() { return false; }
        public void ShowAgent() { }
    }
}
