namespace Aula6_Interface;

class Program
{
    static void Main(string[] args)
    {
        Pilha p = new();
        p.empilha(new string("Iara"));
        p.empilha(123);
        p.empilha(4.321);
        p.empilha(true);

        Console.WriteLine(p.Topo);
        p.desempilha();
        Console.WriteLine(p.Topo);
        p.desempilha();
        Console.WriteLine(p.Topo);
        p.desempilha();
        Console.WriteLine(p.Topo);
        p.desempilha();

        private static void exploraInterface01(Iteste01 i1){
            i1.teste01();
        }
        private static void exploraInterface01(Iteste02 i2){
            i2.teste01();
        }
    }
}
