namespace FlotaNaval.Dominio;

public class Destructor : Barco
{
    public double PotenciaFuego { get; set; }
    public double Maniobrabilidad { get; set; }

    public Destructor(string nombre) : base(nombre)
    {
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Destructor {Nombre} | Fuego {PotenciaFuego} | Maniobra {Maniobrabilidad} | " +
            $"Flotabilidad {Flotabilidad} | Solidez {Solidez} | Estabilidad {Estabilidad} | Crucero {VelocidadCrucero}");
    }
}