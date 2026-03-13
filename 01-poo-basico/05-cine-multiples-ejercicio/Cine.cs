public class Cine
{
    private string pelicula;
    private string horario;

    public void SetPelicula(string p)
    {
        pelicula = p;
    }

    public void SetHorario(string h)
    {
        horario = h;
    }

    public string GetPelicula()
    {
        return pelicula;
    }

    public string GetHorario()
    {
        return horario;
    }
}