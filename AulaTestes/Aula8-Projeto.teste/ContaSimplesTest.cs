namespace Aula8_Projeto.teste;
public class ContaSimplesTest
{
    [Fact]
   public void CriacaoDeContaSimples()
    {
        ContaSimples cs = new(100);

       double resultado = cs.Saldo;

       Assert.Equal(100, resultado);
    }

    [Theory]
    [InlineData(100,100)]
    [InlineData(0,0)]
    [InlineData(-100,0)]

    public void CriacaoDeContaSimplesTheory(double deposito, double resultadoEsperado){
        ContaSimples cs = new(deposito);
        
       double resultado = cs.Saldo;

       Assert.Equal(resultadoEsperado, resultado);
    }
}