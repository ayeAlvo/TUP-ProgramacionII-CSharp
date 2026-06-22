namespace SoporteTecnico.Dominio;

public abstract class Soporte
{
    private Soporte siguiente;

    public void SetSiguiente(Soporte siguiente)
    {
        this.siguiente = siguiente;
    }

    public void Atender(Solicitud solicitud)
    {
        if (PuedeResolver(solicitud))
        {
            Resolver(solicitud);
            solicitud.MarcarResuelta();
        }
        else if (siguiente != null)
        {
            siguiente.Atender(solicitud);
        }
        else
        {
            solicitud.MarcarNoResuelta();
        }
    }

    protected abstract bool PuedeResolver(Solicitud solicitud);

    protected abstract void Resolver(Solicitud solicitud);
}