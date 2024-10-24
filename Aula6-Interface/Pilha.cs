class Pilha: Ipilha, Iteste01, Iteste02{
    private Object [] lista;
    private int count;

    public Pilha()
    {
        lista = new object[10];
        count = 0;
    }
   object? Ipilha.Topo {
        get{
            return(count>0)?lista[count-1]:null;
        }
    }

    object? Ipilha.desempilha(){
        if(count>0){
            return lista[--count];
        }else{
            return null;
        }
        return null;
    }

    void Ipilha.empilha(object o){
        if(count<lista.Length){
            lista[count++]=o;
        }
    }
    public void teste01(){

    }

    void Iteste01.teste01(){
        Console.WriteLine("Implementacao deve valer tanto para o teste 01 quanto para o 02");
    }
    void Iteste01.teste02(){
        Console.WriteLine("Implementacao vale tanto para o teste 01 quanto para o 02");
    }
    void Iteste02.teste02(){
        Console.WriteLine("Implementacao vale para o 02");
    }
}