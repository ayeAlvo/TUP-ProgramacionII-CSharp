
namespace Dominio.Builder;

public class Director
{
    public void Construir(IBuilderComputadora builder)
    {
        builder.AgregarCPU();
        builder.AgregarMemoriaRAM();
        builder.AgregarAlmacenamiento();
        builder.AgregarTarjetaGrafica();
    }
}