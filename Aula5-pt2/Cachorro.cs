class Cachorro: Animal{

    public Cachorro(string nome, decimal peso):base(nome,peso){

    }

    public override string ToString(){
        return "A classe é o "+this.GetType().Name+"\n";
    }

    public new string print(){
        return "Texto elaborado do cachorro usando um new";
    }

    public override string EmiteSom(){
        return "au au au au";
    }

    public void pega(){
        Console.WriteLine("Partiu graveto!!!!!!");
    }

}