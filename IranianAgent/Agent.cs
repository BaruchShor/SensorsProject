using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class Agent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public int NumWeaknesses { get; set; }
        public SensorCoupler SticksSensors { get; set; }
        public Sensor[] TypesOfWeaknesses { get; set; }
        public Sensor[] AttachingSensors { get; set; }
        public Dictionary<Sensor,int> SensorsDict { get; set;} 

        public Agent(string name, int id, string type, int numWeaknesses)
        {
            this.Name = name;
            this.Id = id;
            this.Type = type;
            this.NumWeaknesses = numWeaknesses;
            this.SticksSensors = new SensorCoupler(this.NumWeaknesses);
            this.TypesOfWeaknesses = this.SticksSensors.SensorsCoupler();
            BuildSensorDict();
            this.AttachingSensors = new Sensor[this.TypesOfWeaknesses.Length];
        }
        public bool Activate(Sensor sensor)
        {
            if (this.SensorsDict.ContainsKey(sensor) && this.SensorsDict[sensor] != 0)
            {
                this.SensorsDict[sensor] -= 1;
                return true;
            }
            return false;
        }

        public Dictionary<Sensor, int> BuildSensorDict()
        {
            foreach(Sensor sensor in this.TypesOfWeaknesses)
            {
                if (this.SensorsDict.ContainsKey(sensor))
                {
                    this.SensorsDict[sensor] += 1;
                }
                else
                {
                    this.SensorsDict.Add(sensor, 1);
                }
            }
            return this.SensorsDict;
        }

        public void ShowAgent()
        {
            Console.WriteLine($"----------------------------------------\n" +
                              $"Iranian agent name ::: {this.Name}.\n" +
                              $"Agent ID           ::: {this.Id}.\n" +
                              $"Agent rank         ::: {this.Type}.\n" +
                              $"----------------------------------------\n");
        }
    }
}
