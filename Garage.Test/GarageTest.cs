using Xunit;

namespace MainGarage.Test
{
  public class GarageTest
  {
    private readonly Garage _sut;

    public GarageTest()
    {
      _sut = new Garage();
    }

    [Fact]
    public void ShouldParkACar()
    {
      var vehicle = new Car(2010, "Fiat", 3);

      var result = _sut.TryParkVehicle(vehicle);

      Assert.Equal(0, result);
    }

    [Fact]
    public void ShouldReturnNegativeValueIfTheParkIsFull()
    {
      for (int i = 0; i < 10; i++)
      {
        var vehicle = new Car(2010, "Fiat", 3);
        _sut.TryParkVehicle(vehicle);
      }
      var myVehicle = new Car(2010, "Fiat", 3);

      var result = _sut.TryParkVehicle(myVehicle);

      Assert.Equal(-1, result);
    }

    [Fact]
    public void ShouldRemoveACar()
    {
      var vehicle = new Car(2010, "Fiat", 3);
      _sut.TryParkVehicle(vehicle);

      var carSpot = 0;

      var result = _sut.RemoveVehicle(carSpot);

      Assert.Equal(vehicle, result);
    }

    [Fact]
    public void ShouldReturnNullIfTheSpotIsEmpty()
    {
      var carSpot = 0;

      var result = _sut.RemoveVehicle(carSpot);

      Assert.Null(result);
    }

    [Fact]
    public void ShouldPrintGarageContent()
    {
      var car = new Car(2010, "Fiat", 3);
      var van = new Van(2010, "Fiat", 1000);
      var motorCycle = new MotorCycle(2010, "Aprilia", "Race", 4);
      var car2 = new Car(2008, "Opel", 5);
      var van2 = new Van(2010, "Ducato", 3200);
      var motorCycle2 = new MotorCycle(2010, "Honda", "Naked", 4);

      _sut.TryParkVehicle(car);
      _sut.TryParkVehicle(van);
      _sut.TryParkVehicle(motorCycle);
      _sut.TryParkVehicle(car2);
      _sut.TryParkVehicle(van2);
      _sut.TryParkVehicle(motorCycle2);

      var result = _sut.PrintParkSpots();

      var expectedResult = $"Spot[0] -> {car}\n" + $"Spot[1] -> {van}\n" + $"Spot[2] -> {motorCycle}\n" +
                           $"Spot[3] -> {car2}\n" + $"Spot[4] -> {van2}\n" + $"Spot[5] -> {motorCycle2}\n" +
                           "Spot[6] -> empty\n" + $"Spot[7] -> empty\n" + "Spot[8] -> empty\n" +
                           "Spot[9] -> empty\n";

      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ShouldPrintGarageContentAfterRemoval()
    {
      var car = new Car(2010, "Fiat", 3);
      var van = new Van(2010, "Fiat", 1000);
      var motorCycle = new MotorCycle(2010, "Aprilia", "Race", 4);
      var car2 = new Car(2008, "Opel", 5);
      var van2 = new Van(2010, "Ducato", 3200);
      var motorCycle2 = new MotorCycle(2010, "Honda", "Naked", 4);

      _sut.TryParkVehicle(car);
      _sut.TryParkVehicle(van);
      _sut.TryParkVehicle(motorCycle);

      _sut.RemoveVehicle(0);

      _sut.TryParkVehicle(car2);
      _sut.TryParkVehicle(van2);
      _sut.TryParkVehicle(motorCycle2);
      

      var result = _sut.PrintParkSpots();

      var expectedResult = $"Spot[0] -> {car2}\n" + $"Spot[1] -> {van}\n" + $"Spot[2] -> {motorCycle}\n" +
                           $"Spot[3] -> {van2}\n" + $"Spot[4] -> {motorCycle2}\n" + "Spot[5] -> empty\n" +
                           "Spot[6] -> empty\n" + "Spot[7] -> empty\n" + "Spot[8] -> empty\n" +
                           "Spot[9] -> empty\n";

      Assert.Equal(expectedResult, result);
    }


  }
}
