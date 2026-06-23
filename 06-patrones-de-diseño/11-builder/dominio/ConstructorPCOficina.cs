namespace Dominio.Builder;


public class ConstructorPCOficina : IBuilderComputadora
{
    private Computadora computadora;

    public ConstructorPCOficina()
    {
        computadora = new Computadora();
    }

    public void AgregarCPU()
    {
        computadora.CPU = "Intel Core i5";
    }
    
    public void AgregarMemoriaRAM()
    {
        computadora.MemoriaRAM = "8";
    }

    public void AgregarAlmacenamiento()
    {
        computadora.Almacenamiento = "256";
    }

    public void AgregarTarjetaGrafica()
    {
        computadora.TarjetaGrafica = "Integrada";
    }

    public Computadora ObtenerComputadora()
    {
        return computadora;
    }
}