using Xunit;
using FluentAssertions;
using System;

namespace conversion_tools.Test.Test;

public class TestTestFirstRequirementSuccess
{
    [Trait("Category", "1 - Criou testes de sucesso para o TestConvertStrToInt.")]
    [Theory(DisplayName = "TestConvertStrToInt deve ser executado com sucesso com entradas corretas")]
    [InlineData("4", 4)]
    [InlineData("66", 66)]
    [InlineData("-50", -50)]
    public void TestSucessTestConvertStrToInt(string entry, int expected)
    {
        TestFirstRequirement instance = new();
        Action act = () => instance.TestConvertStrToInt(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestFirstRequirementFail
{
    [Trait("Category", "2 - Criou testes de falha para o TestConvertStrToInt.")]
    [Theory(DisplayName = "TestConvertStrToInt deve ser falhar com entradas incorretas")]
    [InlineData("4", -4)]
    [InlineData("66", -66)]
    [InlineData("-50", 50)]
    public void TestFailTestConvertStrToInt(string entry, int expected)
    {
        TestFirstRequirement instance = new();
        Action act = () => instance.TestConvertStrToInt(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestSecondRequirementSuccess
{
    [Trait("Category", "3 - Criou testes de sucesso para o TestConvertStrToDouble.")]
    [Theory(DisplayName = "TestConvertStrToDouble deve ser executado com sucesso com entradas corretas")]
    [InlineData("4.0", 4.0)]
    [InlineData("66.1", 66.1)]
    [InlineData("-50.3", -50.3)]
    public void TestSucessTestConvertStrToDouble(string entry, double expected)
    {
        TestSecondRequirement instance = new();
        Action act = () => instance.TestConvertStrToDouble(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();        
    }
}

public class TestTestSecondRequirementFail
{
    [Trait("Category", "4 - Criou testes de falha para o TestConvertStrToDouble.")]
    [Theory(DisplayName = "TestConvertStrToDouble deve ser falhar com entradas incorretas")]
    [InlineData("4,0", 4.1)]
    [InlineData("66,1", 66)]
    [InlineData("-50,3", -50)]
    public void TestFailTestConvertStrToDouble(string entry, double expected)
    {
        TestSecondRequirement instance = new();
        Action act = () => instance.TestConvertStrToDouble(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestThirdRequirementSuccess
{
    [Trait("Category", "5 - Criou testes de sucesso para o TestConvertIntToStr.")]
    [Theory(DisplayName = "TestConvertIntToStr deve ser executado com sucesso com entradas corretas")]
    [InlineData(4, "4")]
    [InlineData(66, "66")]
    [InlineData(-50, "-50")]
    public void TestSucessTestConvertIntToStr(int entry, string expected)
    {
        TestThirdRequirement instance = new();
        Action act = () => instance.TestConvertIntToStr(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestThirdRequirementFail
{
    [Trait("Category", "6 - Criou testes de falha para o TestConvertIntToStr.")]
    [Theory(DisplayName = "TestConvertIntToStr deve ser falhar com entradas incorretas")]
    [InlineData(4, "5")]
    [InlineData(66, "60")]
    [InlineData(-50, "50")]
    public void TestFailTestConvertIntToStr(int entry, string expected)
    {
        TestThirdRequirement instance = new();
        Action act = () => instance.TestConvertIntToStr(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestFourthRequirementSuccess
{
    [Trait("Category", "7 - Criou testes de sucesso para o TestConvertDoubleToStr.")]
    [Theory(DisplayName = "TestConvertDoubleToStr deve ser executado com sucesso com entradas corretas")]
    [InlineData(4.1, "4.1")]
    [InlineData(66.3, "66.3")]
    [InlineData(-50.1, "-50.1")]
    public void TestSucessTestConvertDoubleToStr(double entry, string expected)
    {
        TestFourthRequirement instance = new();
        Action act = () => instance.TestConvertDoubleToStr(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestFourthRequirementFail
{
    [Trait("Category", "8 - Criou testes de falha para o TestConvertDoubleToStr.")]
    [Theory(DisplayName = "TestConvertDoubleToStr deve ser falhar com entradas incorretas")]
    [InlineData(4.1, "4")]
    [InlineData(66.3, "66")]
    [InlineData(-50.1, "-50")]
    public void TestFailTestConvertDoubleToStr(double entry, string expected)
    {
        TestFourthRequirement instance = new();
        Action act = () => instance.TestConvertDoubleToStr(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
