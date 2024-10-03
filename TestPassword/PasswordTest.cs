using Xunit;

public class PasswordValidatorsTest
{
    private readonly ValidatorPassword _validator = new ValidatorPassword();


    [Theory]

    [InlineData("Senha123!", true)]
    [InlineData("senha123", false)] // Sem letras mai�sculas e caracteres especiais
    [InlineData("SENHA123!", false)] // Sem letras min�sculas
    [InlineData("Senha!", false)] // Sem n�meros
    [InlineData("12345678", false)] // Sem letras
    [InlineData("Sen123", false)] // Menos de 8 caracteres
    [InlineData("", false)] // Vazia
    [InlineData("       ", false)]

    public void isValidOrNo(string password, bool valorEsperado)
    {
        var resultado = _validator.isValid(password);
        
        Assert.Equal(valorEsperado, resultado);
    }
}