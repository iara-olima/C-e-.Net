using System;

class ContaCorrente{

    //atributo
    private decimal saldo;
    
    private string nome;

    private string dataCriacao;
    
    private int acumulador = 0;
    public ContaCorrente(decimal valor, string nome){
        saldo = valor;
        this.nome = nome; 
    }

    public void Depositar(decimal valor){
        saldo += valor;
        acumulador +=1;
    }

    public void Sacar(decimal valor){
        saldo -= valor;
        acumulador+=1;
    }

    //propriedade de leitura

    public decimal Saldo{
        get{return saldo;}
    }

    public string Nome{
        get{return nome;}
    }

    public string DataCriacao{
        get{return dataCriacao;}
        set{dataCriacao = value;}
    }

    public float SaldoMedio(){
        
        return (float)saldo/acumulador;
    }

}