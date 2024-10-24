public enum tipoConta{simples, poupanca,corrente}

public abstract class ContaAbstrata
{
    public double Saldo{get; protected set;}
    public DateTime DataCriacao { get; //init;
    }

    public uint ID{get;}
    private static uint sequenciadoDeID=1;
    public ContaAbstrata(){
        this.Saldo = 0;
        this.DataCriacao = DateTime.Now;
        this.ID = sequenciadoDeID++;
    }

    public abstract Boolean saque(double valor);
    public abstract Boolean deposito(double valor);

   

}