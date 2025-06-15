# 

/AgentSystem
│
├── Interfaces
│   ├── IAgent.cs
│   ├── ISeniorAgent.cs
│   └── ISensor.cs
│
├── Models
│   ├── Agent.cs
│   ├── SeniorAgent.cs
│   └── Sensor.cs
│
├── Program.cs
├── AgentSystem.csproj
└── README.md

# Agent System

A simulation system for agents and their sensor equipment, distinguishing between regular and senior agents.

---

## 📌 Overview

This system models agents and their interaction with a set of sensors. It defines two levels of agents (regular and senior) and supports activating sensors based on their type and assignment.

---

## 🔧 Interfaces

### `IAgent`
Defines the base interface for all agents.

```csharp
public interface IAgent
{
    string Name { get; set; }
    string Id { get; set; }
    List<ISensor> Sensors { get; set; }

    void Activate(string sensorType);
}

ISeniorAgent
Extends IAgent for senior agents with additional capabilities.

public interface ISeniorAgent : IAgent
{
    void AnalyzeSensorData();
}

ISensor
Describes a sensor with key metadata.

public interface ISensor
{
    string Name { get; set; }
    string Type { get; set; }
    string Assignment { get; set; }
}

Agent
A base class representing a field agent

public class Agent : IAgent
{
    public string Name { get; set; }
    public string Id { get; set; }
    public List<ISensor> Sensors { get; set; }

    public Agent(string name, string id, List<ISensor> sensors)
    {
        Name = name;
        Id = id;
        Sensors = sensors;
    }

    public void Activate(string sensorType)
    {
        foreach (var sensor in Sensors)
        {
            if (sensor.Type == sensorType)
            {
                Console.WriteLine($"Activating sensor: {sensor.Name}");
            }
        }
    }
}

SeniorAgent
An advanced agent with broader capabilities.

public class SeniorAgent : Agent, ISeniorAgent
{
    public SeniorAgent(string name, string id, List<ISensor> sensors)
        : base(name, id, sensors) { }

    public void AnalyzeSensorData()
    {
        Console.WriteLine("Analyzing advanced sensor data...");
    }
}

Sensor
A basic implementation of a sensor.

public class Sensor : ISensor
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Assignment { get; set; }

    public Sensor(string name, string type, string assignment)
    {
        Name = name;
        Type = type;
        Assignment = assignment;
    }
}

🚀 How to Use
Create agents and sensors.

Assign sensors to agents.

Use Activate() method to trigger specific sensor types.

Senior agents can additionally analyze sensor data.

var sensors = new List<ISensor>
{
    new Sensor("ThermalCam", "thermal", "surveillance"),
    new Sensor("AudioMic", "audio", "monitoring")
};

IAgent agent = new Agent("John Doe", "A001", sensors);
agent.Activate("thermal");

ISeniorAgent senior = new SeniorAgent("Jane Smith", "A002", sensors);
senior.AnalyzeSensorData();


📁 Folder Structure Summary
Interfaces: Contains all interface definitions.

Models: Contains implementation classes for agents and sensors.

Program.cs: Entry point to test or run the system.
