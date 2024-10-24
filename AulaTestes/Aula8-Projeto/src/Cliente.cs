public class Cliente{
    public string Nome{get;}
    public DateTime DataNascimento{get;set;}

    public uint ID{get;}

    private static uint sequenciadoDeID = 1;

   public List<ContaAbstrata> listaContas;

    public Cliente(string Nome, DateTime dt)
    {
        this.Nome = Nome;
        this.DataNascimento = dt;
        this.ID = sequenciadoDeID++;
        listaContas = new();
    }

    public override string ToString(){
        double saldo = 0;
        foreach(ContaAbstrata conta in listaContas){
            saldo +=conta.Saldo;
        }

        return $"{this.Nome} : Total R$ {saldo}";
    }

     public void criaConta(tipoConta tc, double saldoInicial, double LimiteContratado){
        ContaAbstrata novaConta;
        switch (tc) {
            case tipoConta.simples:
            novaConta = new ContaSimples(saldoInicial);
            break;
            case tipoConta.poupanca:
            novaConta = new ContaPoupanca(saldoInicial);
            break;
            default:
            novaConta=new ContaCorrente(saldoInicial, LimiteContratado);
            break;
        }
        listaContas.Add(novaConta);
    }
}