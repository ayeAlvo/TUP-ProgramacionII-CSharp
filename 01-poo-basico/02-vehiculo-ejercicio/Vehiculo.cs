public class Vehiculo
{
    public string marca;
    public string modelo;
    private int patente;

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Patente: {patente}");
    }
}