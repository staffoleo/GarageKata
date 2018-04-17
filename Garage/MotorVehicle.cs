namespace MainGarage
{
  public abstract class MotorVehicle
  {
    public int MatriculationYear { get; }
    public string Brand { get; }

    internal MotorVehicle(int matriculationYear, string brand)
    {
      Brand = brand;
      MatriculationYear = matriculationYear;
    }

    public string Print()
    {
      return $"MY: {MatriculationYear}\n" +
             $"Brand: {Brand}\n";
    }
  }
}

