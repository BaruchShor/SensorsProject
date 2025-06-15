
# Agent Intelligence System

## Overview

This system simulates a structure for managing intelligence agents and their sensors. It demonstrates object-oriented principles such as interfaces, inheritance, and polymorphism.

---

## 📁 Project Structure

```
/AgentSystem
│
├── Interfaces/
│   ├── IAgent.cs              # Base interface for all agents
│   └── ISeniorAgent.cs        # Extended interface for senior agents
│
├── Models/
│   ├── Agent.cs               # Basic agent class
│   ├── ComplexAgent.cs        # Inherits from Agent, handles more complex logic
│   ├── ISensor.cs             # Interface for all sensors
│   └── Sensor.cs              # Concrete implementation of a basic sensor
│
└── Program.cs                 # Entry point for testing
```

---

## 🧠 Interfaces

### `IAgent`
```csharp
public interface IAgent
{
    void Activate();
}
```
- **Purpose**: Base behavior for all agent types.
- **Method**: `Activate` - triggers the activation logic based on sensor data.

### `ISeniorAgent`
```csharp
public interface ISeniorAgent : IAgent
{
    void AnalyzeAdvancedData();
}
```
- **Purpose**: Adds advanced behavior for senior agents.
- **Method**: `AnalyzeAdvancedData` - extra logic for complex missions.

---

## 🧍‍♂️ Agent Classes

### `Agent`
```csharp
public class Agent : IAgent
{
    public string Name { get; set; }
    public string Id { get; set; }
    public List<ISensor> Sensors { get; set; }

    public void Activate()
    {
        // Iterates over sensors and checks for trigger condition
    }
}
```
- **Purpose**: Represents a basic field agent with sensors.
- **Key Behavior**: Loops through each sensor and checks for activation logic.

### `ComplexAgent`
```csharp
public class ComplexAgent : Agent, ISeniorAgent
{
    public void AnalyzeAdvancedData()
    {
        // Extra intelligence analysis for senior agents
    }
}
```
- **Purpose**: Represents a senior agent with more sophisticated capabilities.

---

## 🎛️ Sensor System

### `ISensor`
```csharp
public interface ISensor
{
    string Name { get; set; }
    string Type { get; set; }
    string AssignedTo { get; set; }
}
```
- **Purpose**: Abstract sensor structure.

### `Sensor`
```csharp
public class Sensor : ISensor
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string AssignedTo { get; set; }
}
```
- **Purpose**: Concrete sensor implementation used by agents.

---

## 🔁 Flowchart (Textual)

```
START
  │
  ├─> Create Agent (or ComplexAgent)
  │
  ├─> Assign Sensor(s)
  │
  ├─> Call Activate()
  │     ├─> Iterate Sensors
  │     └─> Check Sensor Type
  │
  └─> If ComplexAgent → AnalyzeAdvancedData()
         └─> Extra processing logic
```

---

## 🧪 Example Usage
```csharp
Agent agent = new Agent { Name = "John", Id = "007", Sensors = new List<ISensor>() };
agent.Sensors.Add(new Sensor { Name = "Thermal", Type = "Heat", AssignedTo = "007" });
agent.Activate();

ComplexAgent senior = new ComplexAgent { Name = "Jane", Id = "001", Sensors = new List<ISensor>() };
senior.AnalyzeAdvancedData();
```

---

## 📝 License
This project is provided under the MIT License.
