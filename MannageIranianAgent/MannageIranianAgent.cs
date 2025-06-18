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
        public string[] Options { get; set; }
        public int Choice { get; set; }
        public MannageIranianAgent(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.Options = new string[] { $"::: Please select the agent level for the inquiry. :::\n",
                                           "! 1 ! For Private\n",
                                           "! 2 ! For squad leader\n",
                                           "! 3 ! For Commander\n",
                                           "! 4 ! For chief of Staff\n" };
        }

        public Agent CreateAgent()
        {
            Console.WriteLine($"Please select the agent level for the investigation.");
            try
            {
                do
                {
                    Console.WriteLine("^^^ Please enter your choice from the options. ^^^\n");
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
