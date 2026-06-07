namespace DocumentoStrategy.Dominio;

public class Documento
{
    private string contenido;

    public Documento(string contenido)
    {
        if (contenido == null)
        {
            throw new Exception("El contenido del documento no puede ser nulo.");
        }

        this.contenido = contenido;
    }

    public string GetContenido()
    {
        return this.contenido;
    }
}