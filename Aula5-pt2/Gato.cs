class Gato:Animal{
    public Gato(string nomeBichano, string pesoAnimal):base(nomeBichano, Decimal.Parse(pesoAnimal)){

    }

    
    public override string ToString(){
        return "A classe é do gatinho";
    }

    public new string print(){
        return "Texto elaborado do gatinho usando um new";
    }

    public override string EmiteSom(){
        return "miauuu";
    }

    public void Ronronar(){
        Console.WriteLine("roawnroawn");
    }
}