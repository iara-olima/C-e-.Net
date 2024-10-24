namespace Aula8_Projeto.teste;
public class BancoTest
{
    //ignora esse teste
    [Fact(Skip = "Teste ainda em desenvolvimento")]
   public void CriacaoObjeto()
    {
        Banco b = new();

        Assert.Equal((uint)0,(uint) b.nClientes());
    }
}