using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    internal class Agent : IranianAgentsType
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Counterattack { get; set; }
        public int Choice { get; set; }
        public IranianAgentsTypes Type { get; set; }
        public int NumWeaknesses { get; set; }
        public SensorCoupler SticksSensors { get; set; }
        public int NumberOfShots { get; set; }
        public Sensor[] TypesOfWeaknesses { get; set; }
        public Sensor[] AttachingSensors { get; set; }
        public Dictionary<int, Sensor> SensorsDict { get; set; }
        public SensorsManager SensorAttach { get; set; }
        public string MassegeNumAttach { get; set; }
        public string MassegeIndexAttach { get; set; }
        public List<int> Findings { get; set; }
        public int IsExist { get; set; }
        public Random random { get; }

        public Agent(string name, int id, IranianAgentsTypes type, int numWeaknesses)
        {
            this.Name = name;
            this.Id = id;
            this.Type = type;
            this.NumWeaknesses = numWeaknesses;
            this.SticksSensors = new SensorCoupler(this.NumWeaknesses);
            this.TypesOfWeaknesses = this.SticksSensors.SensorsCoupler();
            this.SensorsDict = new Dictionary<int, Sensor>();
            BuildSensorDict();
            this.AttachingSensors = new Sensor[this.TypesOfWeaknesses.Length];
            this.SensorAttach = new SensorsManager();
            this.MassegeNumAttach = $"Please select the number of sensors to attach.";
            this.MassegeIndexAttach = $"Please select a location to paste.";
            this.random = new Random();
            this.Findings = new List<int>();
        }
        public (int, int, List<int>) ComparingSensors()
        {
            for(int i = 1; i < this.AttachingSensors.Length + 1; i++)
            {
                if (this.AttachingSensors[i - 1].IsActivate)
                {
                    if (this.SensorsDict[i] == this.SensorsDict[i + 1])
                    {
                        this.NumberOfShots += 1;
                        this.Findings.Add(i);
                    }
                }
            }
            this.Counterattack ++;
            return (this.NumberOfShots, this.Counterattack, this.Findings);
        }

        public int Exist()
        {
            int SensorToCheck;
            for(int i = 0; i < this.AttachingSensors.Length - this.Findings.Count; i++)
            {
                do
                {
                    SensorToCheck = random.Next(this.AttachingSensors.Length);
                } while (this.Findings.Contains(SensorToCheck));
                for(int j = 1; j < this.TypesOfWeaknesses.Length + 1; j++)
                {
                    if (!this.Findings.Contains(j) && this.AttachingSensors[SensorToCheck] == this.TypesOfWeaknesses[j])
                    {
                        this.IsExist ++;
                        this.Findings.Add(SensorToCheck);
                    }
                }
            }
            return IsExist;
        }

        public Sensor[] AttachSensors()
        {
            int index;
            int numAttach = SelectChoice(this.MassegeNumAttach);
            for (int i = 0; i < numAttach; i++ )
            {
                index = SelectChoice(this.MassegeIndexAttach);
                this.AttachingSensors[index] = this.SensorAttach.CreateSensor();
            }
            return this.AttachingSensors;
        }

        public int SelectChoice(string massege)
        {
            string userInput;
            do
            {
                Console.WriteLine(massege);
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int resoult))
                {
                    this.Choice = Convert.ToInt32(userInput) - 1;
                }
            } while (this.Choice != 0 && (this.Choice < 0 || this.Choice > this.AttachingSensors.Length));
            return this.Choice;
        }

        public Dictionary<int, Sensor> BuildSensorDict()
        {
            for(int i = 0; i < this.TypesOfWeaknesses.Length; i++)
            {
                    this.SensorsDict[i] = this.TypesOfWeaknesses[i + 1];
            }
            return this.SensorsDict;
        }

        public virtual (Sensor[], Sensor[]) Attack()
        {
            return (this.TypesOfWeaknesses, this.AttachingSensors);
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
