using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class MotionSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.MotionSensor;
        public MotionSensor() : base(Type)
        {

        }
    }
}
