using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class SensorsManager : SensorsType
    {
        public Sensor sensor { get; set; }
        public Agent IranianAgent { get; set; }
        public SensorsTypes TypeCoose { get; set; }
        public MannageIranianAgent AgentCreater { get; set; }
        public string UserInput { get; set; }
        public int Choice { get; set; }
        public string[] SensorsOptions { get; set; }
        public SensorsManager()
        {
            this.SensorsOptions = new string[] { "!!! Please select the sensor to test. !!!",
                                                 "--1-- Audio sensor.",
                                                 "--2-- Thermal sensor.",
                                                 "--3-- Light sensor.",
                                                 "--4-- Magnetic sensor.",
                                                 "--5-- Motion sensor.",
                                                 "--6-- Pulse sensor.",
                                                 "--7-- Signal sensor." 
            };
        }

        public Sensor CreateSensor()
        {
            Console.WriteLine($"!!! Please enter a sensor type. !!!");
            try
            {
                do
                {
                    Console.WriteLine("^^^ Please enter your choice from the options. ^^^\n");
                    GetChoice();
                }
                while (!KeyTypesWords.ContainsKey(this.Choice));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.GetType()} !!!! {ex.Message}");
            }
            this.sensor = this.SensorsCreaterDict[this.KeyTypesWords[this.Choice]]();
            return this.sensor;
        }

        public int GetChoice()
        {
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int resoult))
                {
                    this.Choice = Convert.ToInt32(userInput);
                }
            } while (this.Choice == 0);
            return this.Choice;
        }
    }
}
