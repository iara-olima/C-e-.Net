class Estatico{

//so consigo usar quando o objeto for criado
//private string valor;

//objeto de classe
private static string outroValor="um valor qualquer";

public Estatico(){

}

    public static void imprime(){
        Console.WriteLine("Msg estatica de classe");
        Console.WriteLine(outroValor);
    }

     public void imprimeObj(){
        Console.WriteLine("Msg estatica de instancia");
        Console.WriteLine(outroValor);
    }
}