using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado2 = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert

        Assert.False(resultado2);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado3 = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultado3, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var maiorNumero = 9; 

        // Act
        var resultado4 = _validacoes.RetornarMaiorNumeroLista(lista);


        // Assert
        Assert.Equal(maiorNumero, resultado4);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroNegativoEsperado = -8;

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(numeroNegativoEsperado, resultado);
    }
}
