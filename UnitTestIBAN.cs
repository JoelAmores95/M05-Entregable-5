namespace TestIBAN;

public class UnitTestIBAN
{
    [Fact]
    public void TestIBANEspanolValido()
    {
        string iban = "ES6600190020961234567890";
        bool resultado = IBANValidator.validarIBAN(iban);
        Assert.True(resultado);
    }

    [Fact]
    public void TestIBANInternacionalValidoTodoJunto()
    {
        string iban = "AL35202111090000000001234567";
        bool resultado = IBANValidator.validarIBAN(iban);
        Assert.True(resultado);
    }
    [Fact]
    public void TestIBANInvalido()
    {
        string iban = "1234 5678 9012 3456 7890 1234";
        bool resultado = IBANValidator.validarIBAN(iban);
        Assert.False(resultado);
    }

    [Fact]
    public void TestIBANInternacionalValidoSeparado()
    {
        string iban = "GB82 WEST 1234 5698 7654 32";
        bool resultado = IBANValidator.validarIBAN(iban);
        Assert.True(resultado);
    }

    [Fact]
    public void TestIBANInvalidoSoloLetras()
    {
        string iban = "IBAN INVALIDO";
        bool resultado = IBANValidator.validarIBAN(iban);
        Assert.False(resultado);
    }
}