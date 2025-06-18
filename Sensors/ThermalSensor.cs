using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class ThermalSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.ThermalSensor;
        public ThermalSensor() : base(Type)
        {

        }
    }
}
