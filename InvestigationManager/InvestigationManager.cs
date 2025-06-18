using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject.InvestigationManager
{
    internal class InvestigationManager : SensorsType
    {
        public Sensor sensor { get; set; }
        public SensorsTypes TypeCoose { get; set; }
        public string UserInput { get; set; }
        public InvestigationManager(string agentName)
        {
        }

        public void Researcher()
        {
            Console.WriteLine($"!!! Please enter a sensor type. !!!");
            try
            {
                this.UserInput = Console.ReadLine().ToLower();
            }catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.GetType()} !!!! {ex.Message}");
            }


        }
    }
}
