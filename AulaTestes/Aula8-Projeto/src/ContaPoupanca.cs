public class ContaPoupanca : ContaSimples
{
    public ContaPoupanca(double valorASerDepositado):base(valorASerDepositado)
    {
        
    }

    public virtual void operacaoExtraordinaria(double valorReferencial){
        double valortm,valorvr;
        valortm = Saldo + Saldo*0.05;
        valorvr = Saldo*valorReferencial;
        Saldo += valorvr + valorvr;
    }
}