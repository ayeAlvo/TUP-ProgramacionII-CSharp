// Reglas:

// Hasta 200 g → no hay penalización
// Cada 50 g extra →
// Velocidad −2%
// Altura −5%


public class Dron
{
    public string Modelo { get; set; }
    public int VelocidadBase { get; set; } = 5;
    public int AlturaBase { get; set; } = 100;
    public Herramienta Herramienta { get; private set; }

    public Dron(string modelo) => Modelo = modelo;

    public void AsignarHerramienta(Herramienta herramienta) => Herramienta = herramienta;

    public double CalcularVelocidadFinal()
    {
        int exceso = Math.Max(0, Herramienta.Peso - 200);
        int bloques = exceso / 50;
        double penalizacion = bloques * 0.02;

        return VelocidadBase * (1 - penalizacion);
    }

    public double CalcularAlturaFinal()
    {
        int exceso = Math.Max(0, Herramienta.Peso - 200);
        int bloques = exceso / 50;
        double penalizacion = bloques * 0.05;

        return AlturaBase * (1 - penalizacion);
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Herramienta: {Herramienta.ObtenerDescripcion()}");
        Console.WriteLine($"Peso herramienta: {Herramienta.Peso} g");
        Console.WriteLine($"Velocidad final: {CalcularVelocidadFinal()} m/s");
        Console.WriteLine($"Altura final: {CalcularAlturaFinal()} m");
        Console.WriteLine("--------------------------------------------------");
    }
}