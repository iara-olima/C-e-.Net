class Animal{
    public string Nome{
        get;
        protected set; 
    }
// internsl todos os recursos do mesmo exe acessa o elemento
    public string Especie{
        get;
       // private set; //nao vai ser definido de novo
    }

    public string Classificacao{
        get;
        private set;
    }

    public Animal(string nome, string especie, string classificacao){
        this.Nome = nome;
        this.Especie = especie;
        this.Classificacao = classificacao;
    }

    public Animal(string informacaoUnica){
        this.Nome=informacaoUnica;
        this.Especie=informacaoUnica;
        this.Classificacao = informacaoUnica;
    }

    public void setClassificacao(string classe){
        this.Classificacao = classe;
    }

//virtual: metodo pode ser sobreescrito
    public virtual string print(){
        string resultado;
        resultado = this.GetType().Name +"{\n";
        resultado += " Nome:"+this.Nome+",\n";
        resultado += " Especie:"+this.Especie+",\n";
        resultado +=" Classificacao:"+this.Classificacao+",\n}";
        return resultado;
    }

    public override string ToString(){
        return this.GetType().Name+"==> ("+this.Nome+")";
    }









}//class