namespace FlotaNaval.Dominio;

public class Acorazado : Barco
{
    public double Blindaje { get; set; }
    public double PotenciaFuego { get; set; }

    public Acorazado(string nombre) : base(nombre)
    {
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Acorazado {Nombre} | Blindaje {Blindaje} | Fuego {PotenciaFuego} | " +
            $"Flotabilidad {Flotabilidad} | Solidez {Solidez} | Estabilidad {Estabilidad} | Crucero {VelocidadCrucero}");
    }
}