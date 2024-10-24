namespace Laboratorio5;

class Program
{
    static void Main(string[] args)
    {
        Circulo circ1 = new Circulo();
        Console.WriteLine(circ1);
        Circulo circ2 = new Circulo(2.4,5,3);
        Console.WriteLine(circ2);
        Console.WriteLine("--------------------------");
        CirculoColorido circ3 = new CirculoColorido();
        Console.WriteLine(circ3);
        CirculoColorido circ4 = new CirculoColorido(1.5,3.1,1,"vermelho");
        Console.WriteLine(circ4);

        circ2.CentroX = 10;
        circ2.CentroY = 20;

        circ3.Cor = "azul";
        //modificando uma propriedade da classe pai Circulo, diretamente da classe filha CirculoColorido
        circ4.Raio = 7;
        Console.WriteLine("*******************");
        Console.WriteLine(circ2);
        Console.WriteLine(circ3);
        Console.WriteLine(circ4);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
        CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(3,5,8,"rosa","roxo");
        CirculoColoridoPreenchido circ7 = new CirculoColoridoPreenchido();
        Console.WriteLine(circ5);
        Console.WriteLine(circ6);
        Console.WriteLine(circ7);
Console.WriteLine("___________________________________");
        object[] circulo = new object[3];
        circulo[0]= new Circulo();
        circulo[1] = new CirculoColorido();
        circulo[2] = new CirculoColoridoPreenchido();

        foreach (object o in circulo){
            Console.WriteLine(o.ToString());
        }
    }
}
