using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SensorCoupler : SensorsType
    {
        public SensorsTypes[] SensorsTypeList { get; set; }
        public Sensor[] SensorsAgentList { get; set; }
        public int SensorsListLength { get; set; }
        public Random randon { get; set; }
        public SensorCoupler(int listLength)
        {
            this.SensorsListLength = listLength;
            this.randon = new Random();
            this.SensorsTypeList = (SensorsTypes[])Enum.GetValues(typeof(SensorsTypes));
            this.SensorsAgentList = new Sensor[this.SensorsListLength];
        }

        public Sensor[] SensorsCoupler()
        {
            SensorsTypes type;
            for(int i = 0; i < this.SensorsListLength; i++)
            {
                type = this.SensorsTypeList[randon.Next(this.SensorsTypeList.Length)];
                this.SensorsAgentList[i] = this.SensorsCreaterDict[type]();
            }
            return this.SensorsAgentList;
        }
    }
}
