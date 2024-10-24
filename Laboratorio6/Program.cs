namespace Laboratorio6;

class Program
{
    static void Main(string[] args)
    {
/*
       ContaPoupanca conta1 = new(0.2M, new DateTime(2024,10,18),"Iara");
conta1.Depositar(200);
        string[] titulares = new string[]{"Ana","Bruno","Joao"};

        Conta [] lista = new Conta[10];
        Random r = new Random();
        for(int i =0;i<lista.Length;i++){
            DateTime dataAniversario = new DateTime(2024, r.Next(1, 13), r.Next(1, 29));
                lista[i] = new ContaPoupanca(0.5M,dataAniversario,titulares[r.Next()%titulares.Length]);   
        }
Console.WriteLine(conta1);
        foreach (var conta in lista)
        {
            conta.Depositar(100);
            
            Console.WriteLine(conta);
        }
        foreach (var conta in lista)
        {
            conta.Sacar(50);
            if(conta is ContaPoupanca contaPoupanca){
                contaPoupanca.AdicionarRendimento();
            }
            Console.WriteLine(conta);
        } */

        //posso chamar qualquer metodo 

        
        List<Conta> contas = new List<Conta>();

        contas.Add(new ContaPoupanca(0.5M, new DateTime(2024, 10, 18), "Ana"));
        contas.Add(new ContaPoupanca(0.6M, new DateTime(2024, 11, 20), "Bruno"));
        contas.Add(new ContaPoupanca(0.7M, new DateTime(2024, 12, 25), "Joao"));

        foreach (var conta in contas)
        {
            conta.Depositar(1000);
            conta.Sacar(200);

            if (conta is ContaPoupanca contaPoupanca)
            {
                contaPoupanca.AdicionarRendimento();
            }

            Console.WriteLine(conta);
        }
    }
}
