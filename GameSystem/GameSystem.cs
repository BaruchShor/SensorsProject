using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class GameSystem
    {
        public MannageIranianAgent IranianAgent { get; set; }
        public MagneticSensor Sensors { get; set; }
        public GameSystem()
        {
            EntranceGreeting();
            this.IranianAgent = new MannageIranianAgent();
            this.Sensors = new MagneticSensor();
        }

        public void DisplaySensorsInAgentGame()
        {
            this.IranianAgent.CreateAgent();
            Console.WriteLine(this.IranianAgent.NewAgent);
        }

        public void EntranceGreeting()
        {
            Console.WriteLine($"!!!    :::     Welcome to the Agents and Sensors game.    :::    !!!\n" +
                              $" To start the game, we will need two parameters from you as follows:\n");
        }
        
    }
}
