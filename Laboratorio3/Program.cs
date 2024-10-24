namespace Laboratorio3;

class Program
{
    static int TotalAcimaMedia(List<int> lista){
        int soma = 0, maior=0;
        float media=0;
        for(int i =0; i<lista.Count;i++){
            soma += lista[i];
        }

        media = (float)soma/lista.Count;
        for(int i =0; i<lista.Count;i++){
            if(lista[i]>media){
                maior +=1;
            }
        }
        return maior;
    }

    static List<int> ListaAcimaMedia(List<int>lista){
        int soma = 0;
        List<int> maiorlista = new List<int>();
        float media=0;
        for(int i =0; i<lista.Count;i++){
            soma += lista[i];
        }

        media = (float)soma/lista.Count;
        for(int i =0; i<lista.Count;i++){
            if(lista[i]>media){
               maiorlista.Add(lista[i]);
            }
        }

        return maiorlista;
    }

    static void Main(string[] args)
    {
        List<string> listaStrings = new List<string>();
        listaStrings.Add("Um");
        listaStrings.Add("Hello");
        listaStrings.Add("World");

        Console.WriteLine(listaStrings[0]);
        Console.WriteLine(listaStrings[1]);
        Console.WriteLine(listaStrings[2]);
        //vai gerar erro: listaStrings.Add(10);
    
    Console.WriteLine("--------------------------------------");

    //criacao de fila
    Queue<object> q = new Queue<object>();

    //enfileirando itens
    q.Enqueue(".Net Framework");
    q.Enqueue(new decimal(123.456));
    q.Enqueue(654.321);
    //desfileirando e imprimindo itens
    Console.WriteLine(q.Dequeue());
    Console.WriteLine(q.Dequeue());
    Console.WriteLine(q.Dequeue());
    Console.WriteLine("--------------------------------------");
    
    
    Queue<int> minhaFila = new Queue<int>();
    minhaFila.Enqueue(10);
    minhaFila.Enqueue(200);
    minhaFila.Enqueue(1000);
    Console.WriteLine(minhaFila.Dequeue());
    Console.WriteLine(minhaFila.Dequeue());
    Console.WriteLine(minhaFila.Dequeue());
    Console.WriteLine("--------------------------------------");


    Dictionary<int,string> paises = new Dictionary<int,string>();
    paises[44] = "Reino Unido";
    paises[33] = "França";
    paises[55] = "Brasil";
    Console.WriteLine("O código 55 é: {0}", paises[55]);
    foreach(var item in paises){
        int codigo = item.Key;
        string pais = item.Value;
        Console.WriteLine("Código {0} = {1}", codigo, pais);
    }

    string nome = "Brasil";

    foreach(var i in paises){
        if(i.Value == nome){
            Console.WriteLine($"Codigo do pais {nome} é: {i.Key}");
        }
    }
Console.WriteLine("--------------------------------------");

    List<int> lista = new List<int>();
    for(int i = 0;i<10;i++){
        lista.Add(i+1);
    }
    
    
    Console.WriteLine(TotalAcimaMedia(lista));
    List<int> resultado = ListaAcimaMedia(lista);

    foreach(int i in resultado){
        Console.Write(i+", ");
    }
    }//main
}
