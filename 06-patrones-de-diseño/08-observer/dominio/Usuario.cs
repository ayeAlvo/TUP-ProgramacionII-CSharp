namespace ObserverEjemplo.Dominio;

public class Usuario : IObservador
{
    private string nombre;

    public Usuario(string nombre)
    {
        this.nombre = nombre;
    }

    public void Update(Video video)
    {
        Console.WriteLine(
            this.nombre + " recibió notificación del video: "
            + video.GetTitulo()
        );
    }
}