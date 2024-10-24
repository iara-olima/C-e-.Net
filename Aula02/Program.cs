//dotnet new console -o Aula02 --use-program-main

namespace Aula02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int i = 123;
        Console.WriteLine("i"+i);
        long l = 0;
        Console.WriteLine("i"+i);
        short m = (short)l;
        Console.WriteLine("i"+i);
    }
}
