using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement
{
  [Theory(DisplayName = "convert the value stored in the strVariable variable to an int and store that value in the intVariable variable")]
  [InlineData("42", 42)]
  [InlineData("-1993", -1993)]
  public void TestConvertStrToInt(string entry, int expected)
  {
    ConversionTools instance = new()
    {
      strVariable = entry,
    };
    var strTypeCheck = instance.strVariable is string;
    strTypeCheck.Should().Be(true);
    instance.ConvertStrToInt();
    instance.intVariable.Should().Be(expected);
    var intTypeCheck = instance.intVariable is int;
    intTypeCheck.Should().Be(true);

    }
}

public class TestSecondRequirement
{
  [Theory]
  [InlineData("1.0", 1.0)]
  public void TestConvertStrToDouble(string entry, double expected)
  {
    throw new NotImplementedException();
  }
}

public class TestThirdRequirement
{
  [Theory]
  [InlineData(1, "1")]
  public void TestConvertIntToStr(int entry, string expected)
  {
    throw new NotImplementedException();
  }
}

public class TestFourthRequirement
{
  [Theory]
  [InlineData(4.1, "4.1")]
  public void TestConvertDoubleToStr(double entry, string expected)
  {
    throw new NotImplementedException();
  }
}
