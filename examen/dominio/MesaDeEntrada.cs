namespace SoporteTecnico.Dominio;

public class MesaDeEntrada
{
    private Soporte primerNivel;

    public MesaDeEntrada(Soporte primerNivel)
    {
        this.primerNivel = primerNivel;
    }

    public void Atender(Solicitud solicitud)
    {
        primerNivel.Atender(solicitud);
    }
}