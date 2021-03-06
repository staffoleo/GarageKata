﻿using GarageManager;
using Xunit;

namespace GarageManagerTest
{
  public class VanTest
  {
    private readonly Van _sut;

    public VanTest()
    {
      _sut = new Van(2010, "Fiat", 1000);
    }

    [Fact]
    public void ShouldConvertVanToString()
    {
      var result = _sut.Print();

      string expected = $"MY: {_sut.MatriculationYear}\n" +
                        $"Brand: {_sut.Brand}\n" +
                        $"LoadCapacity: {_sut.LoadCapacity}\n";

      Assert.Equal(expected, result);
    }
  }
}