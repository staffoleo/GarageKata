namespace MainGarage
{
  public class Car : MotorVehicle
  {
    public int DoorNr { get; }

    public Car(int matriculationYear, string brand, int doorNr)
      : base(matriculationYear, brand)
    {
      DoorNr = doorNr;
    }

    public new string Print()
    {
      return base.Print() + $"DoorNr: {DoorNr}\n";
    }
  }
}