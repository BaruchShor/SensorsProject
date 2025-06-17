using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class Sensor : SensorsType
    {
        public string CodeName { get; set;}
        public SensorsTypes Type { get; set; }

        public Sensor(SensorsTypes type)
        {
            this.CodeName = CreateCodeName();
            this.Type = type;
        }

        public string CreateCodeName()
        {
            Random random = new Random();
            int randomNum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    randomNum = random.Next(65, 90);
                    this.CodeName += (char)randomNum;
                }
                else
                {
                    randomNum = random.Next(97, 122);
                    this.CodeName += (char)randomNum;
                }
            }
            return this.CodeName;
        }

        public void Activate()
        {

        }

        public void ShoeSensor()
        {
            Console.WriteLine($"===============================\n" +
                              $"Sensor name ::: {this.CodeName}.\n" +
                              $"Sensor Type ::: {this.Type}\n" +
                              $"===============================\n");
        }
    }
}
