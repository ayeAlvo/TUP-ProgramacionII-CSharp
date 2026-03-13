public class Cine
{
    private string Pelicula;
    private string Horario;

    public void SetPelicula(string p)
    {
        Pelicula = p;
    }

    public void SetHorario(string h)
    {
        Horario = h;
    }

    public string GetPelicula()
    {
        return Pelicula;
    }

    public string GetHorario()
    {
        return Horario;
    }
}