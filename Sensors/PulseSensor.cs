using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class PulseSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.PulseSensor;
        public PulseSensor() : base(Type)
        {

        }
    }
}
