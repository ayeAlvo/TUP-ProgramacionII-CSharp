namespace AdapterEjemplo.Dominio;

public class ServicioEmailViejo
{
    public void MandarCorreo(string texto)
    {
        Console.WriteLine("Email enviado: " + texto);
    }
}