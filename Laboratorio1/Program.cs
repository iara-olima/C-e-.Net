namespace Laboratorio1;
using System.Globalization; 

class Program
{
    static void Main(string[] args)
    {
        // capacidade de armazenar 8 bits sem sinal
        byte b;
        b = byte.MaxValue;
        Console.WriteLine($"Valor maximo de byte: {b}");

        // int armazena 32 bits

        //int i;
        //i = int.MaxValue;
        //Console.WriteLine($"Valor maximo de int: {i}");


        //long armazena ate 64 bits
        long l;
        l = long.MaxValue;
        Console.WriteLine($"Valor maximo de long: {l}");


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        string strPrimeira = "Alo";
        string strSegunda = " Mundo";

        string strTerceira = strPrimeira + strSegunda;
        Console.WriteLine(strTerceira);

        int tamanho = strTerceira.Length;

        string strQuarta = "Tamanho = " + tamanho.ToString();
        Console.WriteLine(strQuarta);
        //Mostra do caractere 0 ao 4
        Console.WriteLine(strTerceira.Substring(0,5));

        Console.WriteLine("-------------------------------------");

        DateTime dt = new DateTime(2024,11,13);

        string strQuinta = dt.ToString();
        Console.WriteLine(strQuinta);

        Console.WriteLine("=======================================================");
        Console.WriteLine("===================== EXERCICIOS ======================");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");
        //float f;
        //f = float.MaxValue;
        //Console.WriteLine($"valor maximo float: {f}");

        double d = double.MaxValue;
        Console.WriteLine($"Valor maximo de double: {d}");

        decimal dec = decimal.MaxValue;
        Console.WriteLine($"Valor maximo de decimal: {dec}");

        string strVazia = string.Empty;
        Console.WriteLine(strVazia); 

        string colunas = "Coluna 1\tColuna 2\tColuna 3";
        Console.WriteLine(colunas);

        string linhas = "Linha 1\r\nLinha 2\r\nLinha 3";
        Console.WriteLine(linhas);

        string texto = @"oiiiiiiiiiiiiiiii
                        aaaaaaaaaaaaaaaaaaaaaaaaa
                    ccccccccccccccccccccccc";

        Console.WriteLine(texto);

        string emoji = "\U0001F47D";
        Console.WriteLine(emoji);

        Console.WriteLine("*****************************");

        
        CultureInfo brasileiro = new CultureInfo("pt-BR");
        
        /*
        "F": Data e hora completas (por exemplo, “terça-feira, 15 de outubro de 2024 10:11:01”).
        "D": Data completa (por exemplo, “15 de outubro de 2024”).
        "d": Data abreviada (por exemplo, “15/10/2024”).
        "T": Hora completa (por exemplo, “10:11:01”).
        "t": Hora abreviada (por exemplo, “10:11”).
        */

        string dataF = dt.ToString("D", brasileiro);
        
        Console.WriteLine(dataF);

        DateTime agora = DateTime.Now;

        string agoraF = agora.ToString("T", brasileiro);
        Console.WriteLine(agoraF);

        Console.WriteLine("**************************************************");

        int i = 10;
        float f = 0;
        f = i; //conversao implicita, sem perda de dados
        Console.WriteLine(f);
        // o F garante que o numero é um float
        f = 0.5F;
        Console.WriteLine(f);
        i = (int)f; //conversao explicita, com perda de dados
        Console.WriteLine(i);

        Console.WriteLine("**************************************************");

        /* string stringInteiro = "123456789";
        int valorStringInteiro = Convert.ToInt32(stringInteiro);
        Console.WriteLine(valorStringInteiro);
        Int64 valorInt64 = 123456789;
        int valorInt = Convert.ToInt32(valorInt64);
        Console.WriteLine(valorInt); */
        string stringInteiro = "123456789";
        int valorStringInteiro;
        bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
        Console.WriteLine($"Conversao efetuada: {conversao1} Valor: {valorStringInteiro}");

        string stringInteiroGrande = "999999999999999999999999999999999999999999999";
        int valorStringInteiroGrande;
        bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
        Console.WriteLine($"Conversao efetuada: {conversao2} Valor: {valorStringInteiroGrande}");

        string stringLetras = "abc";
        double valorStringLetras;
        bool conversao3 = double.TryParse(stringLetras, out valorStringLetras);
        Console.WriteLine($"Conversao efetuada: {conversao3} Valor: {valorStringLetras}");

        Console.WriteLine("**************************************************");

        double valorFracionado = 4.7;
        
        //trunca
        int valorInteiro1 = (int)valorFracionado;

        //arredonda
        int valorInteiro2 = Convert.ToInt32(valorFracionado);
        Console.WriteLine($"Conversao explicita: {valorInteiro1}");
        Console.WriteLine($"Conversao metodo Convert: {valorInteiro2}");

        Console.WriteLine("**************************************************");

        int x = 10;
        double y = 3.4;
        //{0} {1} é a ordem das variaveis
        Console.WriteLine("{0} {1}",x,y);
        Console.WriteLine($"{x} {y}");
    }
}
