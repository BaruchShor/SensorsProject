using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class MagneticSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.MagneticSensor;
        public MagneticSensor() : base(Type)
        {

        }
    }
}
