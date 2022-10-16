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
  [Theory(DisplayName = "convert the value stored in the strVariable variable to an double and store that value in the doubleVariable variable")]
  [InlineData("1.0", 1.0)]
  public void TestConvertStrToDouble(string entry, double expected)
  {
        ConversionTools instance = new()
    {
      strVariable = entry,
    };
    var strTypeCheck = instance.strVariable is string;
    strTypeCheck.Should().Be(true);
    instance.ConvertStrToDouble();
    instance.doubleVariable.Should().Be(expected);
    var doubleTypeCheck = instance.doubleVariable is double;
    doubleTypeCheck.Should().Be(true);
  }
}

public class TestThirdRequirement
{
  [Theory(DisplayName = "converts the value stored in the intVariable variable to a string and storing that value in the")]
  [InlineData(1, "1")]
  public void TestConvertIntToStr(int entry, string expected)
  {
     ConversionTools instance = new()
    {
      intVariable = entry,
    };
    var intTypeCheck = instance.intVariable is int;
    intTypeCheck.Should().Be(true);
    instance.ConvertIntToStr();
    instance.strVariable.Should().Be(expected);
    var stringTypeCheck = instance.strVariable is string;
    stringTypeCheck.Should().Be(true);
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
