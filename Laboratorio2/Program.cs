namespace Laboratorio2;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5] {10,20,30,40,50};
        int i;
        for(i = 0; i<5;i++){
            Console.WriteLine($"Indice: {i}\r\nValor: {array[i]}");
        }
Console.WriteLine("");
        string[] str = new string[3];
        int iStr;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        for(iStr = 0;iStr < 3; iStr++){
            Console.WriteLine($"Indice: {iStr}\r\nValor: {str[iStr]}");
        }
    Console.WriteLine("#####################################################");

    DateTime[] dt = new DateTime[2];
    int iDate;
    dt[0] = new DateTime(2006,1,3);
    dt[1] = new DateTime(2005,1,17);
    for(iDate = 0; iDate < 2; iDate++){
       Console.WriteLine($"Indice: {iDate} Data: {dt[iDate].ToShortDateString()}");
    }

    foreach(DateTime data in dt){
        Console.WriteLine($"Data: {data.ToShortDateString()}");
    }
    
    int[] Arrayy = new int[100];
    string[] strArray = new string[100];
    int[] iArray = new int[100];
    for(i=0;i<100;i++){
        Arrayy[i] = i;
    }
    Array.Copy(Arrayy,iArray,100);
    for(i=0;i<100;i++){
        strArray[i] = Convert.ToString(Arrayy[i]);

    }
    for(i=0;i<100;i++){
        Console.WriteLine(iArray[i]);
    }
    for(i=0;i<100;i++){
        Console.WriteLine(strArray[i]);
    }
    

    Console.WriteLine(@"***********************************
*************************************************");
/*
    int[,] matriz = new int[5,5];

    int linha, coluna, soma=0;

    for(linha = 0;linha<5;linha++){
        for(coluna = 0;coluna <5;coluna++){
            matriz[linha,coluna] = linha+1;
        }
    }

    for(coluna = 0;coluna<5;coluna++){
        for(linha=0;linha<5;linha++){
            soma += matriz[linha,coluna];
            
        }
        Console.WriteLine($"Soma coluna {coluna}: {soma}");
            soma = 0;
    }

for(linha = 0;linha<5;linha++){
        for(coluna = 0;coluna <5;coluna++){
            Console.Write(" "+matriz[linha,coluna]);
        }
        Console.WriteLine("");
    }

    */

    Console.WriteLine("================================================");
    int linha, coluna;
       int[][] jagged = new int[5][];
       jagged[0]= new int[5]{1,1,1,1,1};
       jagged[1]= new int[5]{2,2,2,2,2};
       jagged[2]= new int[5]{3,3,3,3,3};
       jagged[3]= new int[5]{4,4,4,4,4};
       jagged[4]= new int[5]{5,5,5,5,5};
int[] columnSums = new int[5];
        for(linha=0;linha<jagged.Length;linha++){
            for(coluna=0;coluna<jagged[linha].Length;coluna++){
                 Console.WriteLine("Jagged: ["+linha+"]["+coluna+"]: "+jagged[linha][coluna]);
            }

        }

        for (coluna = 0; coluna < 5; coluna++) {
    for (linha = 0; linha < jagged.Length; linha++) {
        columnSums[coluna] += jagged[linha][coluna];
    }
}

for (coluna = 0; coluna < columnSums.Length; coluna++) {
    Console.WriteLine($"Soma da coluna {coluna}: {columnSums[coluna]}");
}
/*
    int [][] jagged = new int[5][];
    jagged[0] = new int[2];
    jagged[1] = new int[2];
    for(linha = 0;linha<2;linha++){
        for(coluna = 0;coluna<2;coluna++){
            jagged[linha][coluna] = i+1;
        }
    }

    for(linha = 0;linha<2;linha++){
        for(coluna = 0;coluna<2;coluna++){
            Console.WriteLine("Jagged: ["+linha+"]["+coluna+"]: "+jagged[linha][coluna]);
        }
    } */
    
    } //main
}
