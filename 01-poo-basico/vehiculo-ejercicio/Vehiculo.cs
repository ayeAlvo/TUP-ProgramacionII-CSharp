public class Vehiculo
{
    public string Marca;
    public string Modelo;
    private int Patente;

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Patente: {Patente}");
    }
}