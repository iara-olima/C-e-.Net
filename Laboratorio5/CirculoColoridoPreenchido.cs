class CirculoColoridoPreenchido: CirculoColorido
{
    private string corAdicional;

    public string CorAdicional{
    get{ return corAdicional;}
    set{ corAdicional = value;}
    }

    public CirculoColoridoPreenchido()
    {
        corAdicional = "verde";
    }
    public CirculoColoridoPreenchido(double x, double y, double r, string c,string cor):base(x,y,r,c)
    {
        corAdicional = cor;        
    }

    public override string ToString(){
        return base.ToString()+" cor adicional:" + CorAdicional;
    }
}