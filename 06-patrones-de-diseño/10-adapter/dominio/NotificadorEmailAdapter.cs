namespace AdapterEjemplo.Dominio;

public class NotificadorEmailAdapter : INotificador
{
    private ServicioEmailViejo servicioEmailViejo;

    public NotificadorEmailAdapter(ServicioEmailViejo servicioEmailViejo)
    {
        this.servicioEmailViejo = servicioEmailViejo;
    }

    public void Enviar(string mensaje)
    {
        this.servicioEmailViejo.MandarCorreo(mensaje);
    }
}