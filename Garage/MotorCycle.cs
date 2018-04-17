namespace MainGarage
{
  public class MotorCycle : MotorVehicle
  {
    public string MotorType { get; }
    public int StrokeEngine { get; }

    public MotorCycle(int matriculationYear, string brand, string type, int strokeEngine)
      : base(matriculationYear, brand)
    {
      MotorType = type;
      StrokeEngine = strokeEngine;
    }

    public new string Print()
    {
      return base.Print() + $"MotorType: {MotorType}\n" + $"StrokeEngine: {StrokeEngine}\n";
    }
  }
}