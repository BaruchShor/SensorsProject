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

        public Dictionary<SensorsTypes, Func<Sensor>> SensorsCreaterDict = new Dictionary<SensorsTypes, Func<Sensor>>
        {
            { SensorsTypes.AudioSensor,() => new AudioSensor()},
            { SensorsTypes.LightSensor,() => new LightSensor()},
            { SensorsTypes.MagneticSensor,() => new MagneticSensor()},
            { SensorsTypes.MotionSensor,() => new MotionSensor()},
            { SensorsTypes.PulseSensor,() => new PulseSensor()},
            { SensorsTypes.SignalSensor,() => new SignalSensor()},
            { SensorsTypes.ThermalSensor,() => new ThermalSensor()},
        };

        public Dictionary<int, SensorsTypes> KeyTypesWords = new Dictionary<int, SensorsTypes>
        {
            { 1, SensorsTypes.AudioSensor},
            { 2 , SensorsTypes.ThermalSensor},
            { 3, SensorsTypes.LightSensor},
            { 4, SensorsTypes.MagneticSensor},
            { 5, SensorsTypes.MotionSensor},
            { 6, SensorsTypes.PulseSensor},
            { 7, SensorsTypes.SignalSensor}
        };
    }
}
