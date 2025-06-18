using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SignalSensor : Sensor
    {
        private static SensorsTypes Type = SensorsTypes.SignalSensor;
        public SignalSensor() : base(Type)
        {

        }
    }
}
