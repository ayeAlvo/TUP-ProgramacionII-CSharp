namespace FacadeClinica.Dominio;

public class ClinicaFacade
{
    private SistemaTurnos turnos;
    private SistemaHistoriaClinica historiaClinica;
    private SistemaFacturacion facturacion;
    private SistemaNotificaciones notificaciones;

    public ClinicaFacade()
    {
        turnos = new SistemaTurnos();
        historiaClinica = new SistemaHistoriaClinica();
        facturacion = new SistemaFacturacion();
        notificaciones = new SistemaNotificaciones();
    }

    public void RegistrarConsulta()
    {
        turnos.ConfirmarTurno();
        historiaClinica.RegistrarAtencion();
        facturacion.GenerarFactura();
        notificaciones.EnviarAviso();
    }
}