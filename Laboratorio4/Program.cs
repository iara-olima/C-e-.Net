namespace Laboratorio4;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        ContaCorrente minhaConta = new ContaCorrente(340,"Iara");
        minhaConta.DataCriacao = dt.ToString();
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(minhaConta.Saldo);
        Console.WriteLine(minhaConta.Nome);
        Console.WriteLine(minhaConta.DataCriacao);
        Console.WriteLine(minhaConta.SaldoMedio());
    }
}
