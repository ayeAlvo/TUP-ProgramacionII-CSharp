namespace Dominio.Builder;


public class Computadora
{
    public string CPU;
    public string MemoriaRAM;
    public string Almacenamiento;
    public string TarjetaGrafica;

    public string Detalle()
    {
        return $"Computadora: CPU={CPU}, MemoriaRAM={MemoriaRAM}GB, Almacenamiento={Almacenamiento}GB, TarjetaGrafica={TarjetaGrafica}";
    }
}