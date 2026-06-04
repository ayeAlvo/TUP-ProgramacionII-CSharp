namespace Singleton.Dominio;

public class Configuracion
{
    private static Configuracion? instancia;

    public string NombreSistema { get; set; }

    private Configuracion()
    {
        NombreSistema = "Sistema Principal";
    }

    public static Configuracion ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Configuracion();
        }

        return instancia;
    }
}