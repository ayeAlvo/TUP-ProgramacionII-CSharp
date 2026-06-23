namespace Dominio.Builder;

public class ConstructorPCGamer : IBuilderComputadora
{
    private Computadora computadora;

    public ConstructorPCGamer()
    {
        computadora = new Computadora();
    }

    public void AgregarCPU()
    {
        computadora.CPU = "Intel Core i9";
    }

    public void AgregarMemoriaRAM()
    {
        computadora.MemoriaRAM = "32";
    }

    public void AgregarAlmacenamiento()
    {
        computadora.Almacenamiento = "SDD 1TB";
    }

    public void AgregarTarjetaGrafica()
    {
        computadora.TarjetaGrafica = "NVIDIA RTX 3080";
    }

    public Computadora ObtenerComputadora()
    {
        return computadora;
    }
}