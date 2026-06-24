namespace ObserverEjemplo.Dominio;

public class Canal : ISujeto
{
    private string nombre;
    private List<IObservador> observadores;
    private List<Video> videos;

    public Canal(string nombre)
    {
        this.nombre = nombre;
        this.observadores = new List<IObservador>();
        this.videos = new List<Video>();
    }

    public void Attach(IObservador observador)
    {
        this.observadores.Add(observador);
    }

    public void Detach(IObservador observador)
    {
        this.observadores.Remove(observador);
    }

    public void Notify(Video video)
    {
        foreach (IObservador observador in this.observadores)
        {
            observador.Update(video);
        }
    }

    public void PublicarVideo(Video video)
    {
        this.videos.Add(video);

        Console.WriteLine(
            "El canal " + this.nombre
            + " publicó: "
            + video.GetTitulo()
        );

        this.Notify(video);
    }
}