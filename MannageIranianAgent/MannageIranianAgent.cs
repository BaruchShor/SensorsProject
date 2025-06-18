using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class MannageIranianAgent : IranianAgentsType
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Agent NewAgent { get; set; }
        public string[] RankOptions { get; set; }
        public int Choice { get; set; }
        public MannageIranianAgent()
        {
            this.Name = GetAgentName(); ;
            this.Id = GetAgentId(); ;
            this.RankOptions = new string[] { $"::: Please select the agent level for the inquiry. :::\n",
                                           "! 1 ! For Private\n",
                                           "! 2 ! For squad leader\n",
                                           "! 3 ! For Commander\n",
                                           "! 4 ! For chief of Staff\n" };
        }

        public Agent CreateAgent()
        {
            Console.WriteLine($"Please select the agent {this.Name} level for the investigation.");
            try
            {
                do
                {
                    foreach(string option in this.RankOptions)
                    {
                        Console.WriteLine(option);
                    }
                    GetChoice();

                } while (!this.KeyTypesWords.ContainsKey(this.Choice));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.GetType()} !!!! {ex.Message}");
            }

            this.NewAgent = this.AgentsCreaterDict[this.KeyTypesWords[this.Choice]](this.Name, this.Id);

            return this.NewAgent;
        }

        public string GetAgentName()
        {
            Console.WriteLine($"===1=== Please enter the name of the agent.\n");
            this.Name = Console.ReadLine();
            return this.Name;
        }
        public int GetAgentId()
        {
            Console.WriteLine($"===2=== Please enter the ID of the agent.\n");
            this.Name = Console.ReadLine();
            return this.Id;
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
