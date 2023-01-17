namespace TestIBAN;

public class UnitTestCCC
{
    [Fact]
    public void TestCCCValidoJunto()
    {
        string ccc = "20854441715273797857";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.True(result);
    }

    [Fact]
    public void TestCCCValidoSeparado()
    {
        string ccc = "2085 4441 71 5273797857";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.True(result);
    }

    [Fact]
    public void TestCCCValidoGuiones()
    {
        string ccc = "2085-4441-71-5273797857";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.True(result);
    }

    [Fact]
    public void TestCCCInvalidoSimbolos()
    {
        string ccc = " 2085 4441 ** 5273****** ";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.False(result);
    }

    [Fact]
    public void TestCCCInvalidoTachado()
    {
        string ccc = " 2085 4441 XX 5273XXXXXX ";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.False(result);
    }

    [Fact]
    public void TestCCCInvalidoLetras()
    {
        string ccc = "INVALID CCC";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.False(result);
    }
    [Fact]
    public void TestCCCInvalido()
    {
        string ccc = "1234 1234 1234 12 123456";
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.False(result);
    }

    [Fact]
    public void TestCCCGenerado()
    {
        string ccc = CCCGenerator.GenerateValidCCC("208544417152737978XX");
        bool result = CCCValidator.ValidarCCC(ccc);
        Assert.True(result);
    }

}