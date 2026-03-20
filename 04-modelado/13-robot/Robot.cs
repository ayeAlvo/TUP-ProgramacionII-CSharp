public class Robot
{
    public string NumeroDeSerie { get; set; }
    public int PotenciaDeTraccionBase { get; set; }
    public TipoTraccion Traccion { get; set; }

    public Robot(string numeroDeSerie, int ptb, TipoTraccion traccion)
    {
        NumeroDeSerie = numeroDeSerie;
        PotenciaDeTraccionBase = ptb;
        Traccion = traccion;
    }

    public int PotenciaFinal()
    {
        return PotenciaDeTraccionBase - Traccion.DescuentoPotencia;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Robot {NumeroDeSerie}");
        Console.WriteLine($"Potencia final: {PotenciaFinal()} hp");
        Console.WriteLine($"Sistema de tracción:");
        Traccion.MostrarDatos();
        Console.WriteLine("----------------------------------");
    }
}