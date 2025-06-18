using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    interface IAgent
    {
        string Name { get; set; }
        int Id { get; set; }
        string Type { get; set; }
        List<Sensor> TypesOfWeaknesses { get; set; }
        Dictionary<Sensor, int> SensorsDict { get; set; }

        bool Activate();
        void ShowAgent();
    }
}
