namespace Aula5_pt2;

class Program
{
    static void Main(string[] args)
    {
        Animal a = new("toto",12.5M);
        Console.WriteLine(a);
        Console.WriteLine(a.EmiteSom());
         Console.WriteLine("---------------------------------");
        a =  new Cachorro("rex",12.75M);
        Console.WriteLine(a);
        Console.WriteLine(a.print());
        Console.WriteLine(a.EmiteSom());

        Console.WriteLine("a é um Animal?"+(a is Animal));
        Console.WriteLine("a é um Cachorro?"+(a is Cachorro));
        Console.WriteLine("a é um Gato?"+(a is Gato));

        if (a is Cachorro){
            Console.WriteLine("Atuando como cachorro");
            Console.WriteLine((a as Cachorro));
            Console.WriteLine((a as Cachorro)?.print());
            Console.WriteLine((a as Cachorro)?.EmiteSom());
            (a as Cachorro)?.pega();
        }
Console.WriteLine("-----------------------------------------");
        a = new Gato("Agatha", "2,5");
         Console.WriteLine(a);
        Console.WriteLine(a.print());
        Console.WriteLine(a.EmiteSom());

        Console.WriteLine("a é um Animal?"+(a is Animal));
        Console.WriteLine("a é um Cachorro?"+(a is Cachorro));
        Console.WriteLine("a é um Gato?"+(a is Gato));

        if (a is Gato){
            Console.WriteLine("Atuando como um gatinho");
            Console.WriteLine((a as Gato));
            Console.WriteLine((a as Gato)?.print());
            Console.WriteLine((a as Gato)?.EmiteSom());
            (a as Gato)?.Ronronar();
        }
           Console.WriteLine("****************************");
Console.WriteLine("");
        Object [] listaPets = new object[5];
        listaPets[0] = new Animal("coisa",1.25M);
        listaPets[1] = new Cachorro("bob",5M);
        listaPets[1] = new Gato("mingau","3,4");
Console.WriteLine("****************************");
        foreach(object o in listaPets){
            Console.WriteLine(o??"O objeto não existe");
            if(o is Animal) Console.WriteLine((o as Animal)?.print());
            if(o is Gato) Console.WriteLine((o as Gato)?.print());
            if(o is Cachorro) Console.WriteLine((o as Cachorro)?.print());

    }
    //atributo? metodo? propriedade?
    }
}
