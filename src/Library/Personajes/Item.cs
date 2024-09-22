namespace Library;

public class Item
{
    private string nombre;
    private double ataque;
    private double defensa;

    public Item(string nombre, double ataque, double defensa)
    {
        this.nombre = nombre;
        this.ataque = ataque;
        this.defensa = defensa;
    }

    public string GetNombre
    {
        get{return nombre; }
    }
    
    public double GetAtaque
    {
       get{return ataque;}
    }

    public double GetDefensa
    {
        get { return defensa; }
    }
    
}