namespace Dominio.Builder;


public interface IBuilderComputadora
{
    public void AgregarCPU();
    public void AgregarMemoriaRAM();
    public void AgregarAlmacenamiento();
    public void AgregarTarjetaGrafica();
    public Computadora ObtenerComputadora();
}