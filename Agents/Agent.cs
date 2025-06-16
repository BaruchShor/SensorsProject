using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class Agent : IAgent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
