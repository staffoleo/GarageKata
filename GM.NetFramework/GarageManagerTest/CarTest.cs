using GarageManager;
using Xunit;

namespace GarageManagerTest
{
  public class CarTest
  {
    public CarTest()
    {
      _sut = new Car(2010, "Fiat", 3);
    }

    private readonly Car _sut;

    [Fact]
    public void ShouldPrintCar()
    {
      var result = _sut.Print();

      var expected = $"MY: {_sut.MatriculationYear}\n" +
                     $"Brand: {_sut.Brand}\n" +
                     $"DoorNr: {_sut.DoorNr}\n";

      Assert.Equal(expected, result);
    }
  }
}