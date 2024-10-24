public class Banco
{
    
    List<Cliente> lista;

    public Banco(){
        lista = new();
    }

    public void cadastraCliente(string nome, DateTime dataNascimento){
        Cliente cliente = new Cliente(nome, dataNascimento);
        lista.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nome}[{cliente.ID}] cadastrado com sucesso");
    }

    public void listaClientes(){
        if(lista.Count == 0){
            Console.WriteLine("Não há clientes cadastrados");
        }else{
            Console.WriteLine("Segue a lista de clientes");
            foreach (var cliente in lista)
                Console.WriteLine($"[{cliente.ID} {cliente.Nome}]");
        }
    }

    public void cadastraConta(uint IDCliente, tipoConta tc, double saldoInicial, double credito){
        Cliente? c = lista.Find(cliente => cliente.ID == IDCliente);
        c?.criaConta(tc, saldoInicial, credito);
    }

    public uint nClientes(){
        return (uint)lista.Count;
    }

      private Cliente? search(uint IDCliente){
        Cliente? result=null;
        foreach(Cliente c in lista)
            if(c.ID==IDCliente){
                result=c;
                break;
            } 
        return result;

    }

    public void detalhaCliente(uint IDCliente){
        Cliente? c = lista.Find(cliente => cliente.ID == IDCliente);
        if(c==null){
            Console.WriteLine($"O cliente {IDCliente} não foi encontrado");
        }else{
            Console.Write($"O cliente [{IDCliente}] {c.Nome}");
            if(c.listaContas.Count == 0){
                Console.WriteLine(" não possui contas cadastradas");
            }else{
                Console.WriteLine($" possui {c.listaContas.Count} contas cadastradas");
                foreach (var conta in c.listaContas)
                {
                    Console.WriteLine($"[{conta.ID}] {conta.GetType().Name} => Saldo {conta.Saldo}");
                }
            }

        }
    }
}