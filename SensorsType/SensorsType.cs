using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SensorsType
    {
        public enum SensorsTypes
        {
            AudioSensor,
            LightSensor,
            MagneticSensor,
            MotionSensor,
            PulseSensor,
            SignalSensor,
            ThermalSensor
        }

        public Dictionary<SensorsTypes, Sensor> SensorsDict = new Dictionary<SensorsTypes, Sensor>
        {
                { SensorsTypes.AudioSensor, new AudioSensor()},
                { SensorsTypes.LightSensor, new LightSensor()},
                { SensorsTypes.MagneticSensor, new MagneticSensor()},
                { SensorsTypes.MotionSensor, new MotionSensor()},
                { SensorsTypes.PulseSensor, new PulseSensor()},
                { SensorsTypes.SignalSensor, new SignalSensor()},
                { SensorsTypes.ThermalSensor, new ThermalSensor()},
        };
    }
}
