namespace SoporteTecnico.Dominio;

public class Solicitud
{
    private string categoria;
    private int complejidad;
    private string estado;

    public Solicitud(string categoria, int complejidad)
    {
        this.categoria = categoria;
        this.complejidad = complejidad;
        this.estado = "Pendiente";
    }

    public string GetCategoria()
    {
        return categoria;
    }

    public int GetComplejidad()
    {
        return complejidad;
    }

    public void MarcarResuelta()
    {
        estado = "Resuelta";
    }

    public void MarcarNoResuelta()
    {
        estado = "No resuelta";
    }

    public string GetEstado()
    {
        return estado;
    }
}