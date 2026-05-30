namespace Cartas.Dominio;

public class Carta
{
    public string Destinatario { get; set; }

    public Carta(string destinatario)
    {
        Destinatario = destinatario;
    }

    public override string ToString()
    {
        return Destinatario;
    }
}