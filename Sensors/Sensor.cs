using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class Sensor : ISensor
    {
        public string Name { get; set;}
        public int Id { get; set; }
        public string Type { get; set; }

        public Sensor(string name, int id, string Type)
        {
            this.Name = name;
            this.Id = id;
            this.Type = Type;
        }

        public void ShoeSensor()
        {
            Console.WriteLine($"===============================\n" +
                              $"Sensor name ::: {this.Name}.\n" +
                              $"Sensor Id   ::: {this.Id}.\n" +
                              $"Sensor Type ::: {this.Type}\n" +
                              $"===============================\n");
        }
    }
}
