using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class IAgent
    {
        string Name { get; set; }
        string Type { get; set; }
        Dictionary<Sensor> SensorsDict { get; set; }

        void Activate() { }
    }
}
