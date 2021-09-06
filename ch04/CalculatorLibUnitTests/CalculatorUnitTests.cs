using Packt;
using System;
using Xunit;

namespace CalculatorLibUnitTests
{
  public class CalculatorUnitTests
  {
    [Fact]
    public void TestMultiply10And10()
    {
      // arrange 
      int a = 10;
      int b = 10;
      int expected = 100;
      Calculator calc = new Calculator();

      // act
      int actual = calc.Muptiply(a, b);

      // assert 
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMultiply5And5()
    {
      // arrange 
      int a = 5;
      int b = 5;
      int expected = 25;
      Calculator calc = new Calculator();

      // act
      int actual = calc.Muptiply(a, b);

      // assert 
      Assert.Equal(expected, actual);
     
    }
  }
}