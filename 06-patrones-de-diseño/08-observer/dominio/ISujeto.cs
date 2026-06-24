namespace ObserverEjemplo.Dominio;

public interface ISujeto
{
    void Attach(IObservador observador);

    void Detach(IObservador observador);

    void Notify(Video video);
}