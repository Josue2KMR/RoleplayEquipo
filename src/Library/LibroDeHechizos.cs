namespace Library;

public class LibroDeHechizos
{
    private string name;
    private List<string> ListaHechizos;
    private int conocimientoMago;

    public LibroDeHechizos(string name, List<string> listaHechizos, int conocimientoMago)
    {
        this.name = name;
        this.ListaHechizos = listaHechizos;
        this.conocimientoMago = conocimientoMago;
    }
    

        public List<string> GetListaHechizos
    {
        get { return ListaHechizos; }

    }

    public int GetConocimiento
    {
        set { conocimientoMago = ListaHechizos.Count; }
    }
}