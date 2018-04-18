using System;

namespace GarageManager
{
  public class Van : MotorVehicle
  {
    public int LoadCapacity { get; }

    public Van(int matriculationYear, string brand, int loadCapacity)
      : base(matriculationYear, brand)
    {
      LoadCapacity = loadCapacity;
    }

    public new string Print()
    {
      return base.Print() + $"LoadCapacity: {LoadCapacity}\n";
    }
  }
}

