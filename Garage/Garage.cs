namespace MainGarage
{
  public class Garage
  {
    public MotorVehicle[] Vehicles = new MotorVehicle[10];

    public int TryParkVehicle(MotorVehicle vehicle)
    {
      for (int i = 0; i < 10; i++)
      {
        if (Vehicles[i] != null) continue;
        Vehicles[i] = vehicle;
        return i;
      }

      return -1;
    }

    public MotorVehicle RemoveVehicle(int parkSpot)
    {
      var motorVehicle = Vehicles[parkSpot];
      Vehicles[parkSpot] = null;
      return motorVehicle;
    }

    public string PrintParkSpots()
    {
      var parkSituation = string.Empty;
      for (int i = 0; i < 10; i++)
      {
        if (Vehicles[i] == null)
        {
          parkSituation += $"Spot[{i}] -> empty\n";
        }
        else
        {
          parkSituation += $"Spot[{i}] -> {Vehicles[i]}\n";
        }
      }

      return parkSituation;
    }
  }
}