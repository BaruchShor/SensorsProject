using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class LightSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.LightSensor;
        public LightSensor() : base(Type)
        {

        }
    }
}
