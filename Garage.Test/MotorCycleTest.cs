using Xunit;

namespace MainGarage.Test { 
	public class MotorCycleTest {

	  private readonly MotorCycle _sut;

	  public MotorCycleTest() {
	    _sut = new MotorCycle(2010, "Fiat", "Enduro", 2);
    }

	  [Fact]
	  public void ShouldConvertCarToString()
	  {
	    var result = _sut.Print();

	    string expected = $"MY: {_sut.MatriculationYear}\n" +
                        $"Brand: {_sut.Brand}\n" +
	                      $"MotorType: {_sut.MotorType}\n" + 
	                      $"StrokeEngine: {_sut.StrokeEngine}\n";

      Assert.Equal(expected, result);
	  }
	}
}