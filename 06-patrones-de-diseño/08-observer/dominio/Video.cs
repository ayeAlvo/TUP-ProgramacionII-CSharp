namespace ObserverEjemplo.Dominio;

public class Video
{
    private string titulo;

    public Video(string titulo)
    {
        this.titulo = titulo;
    }

    public string GetTitulo()
    {
        return titulo;
    }
}