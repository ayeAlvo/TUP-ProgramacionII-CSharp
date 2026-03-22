namespace FlotaNaval.Dominio;

public class LanchaMedica : Barco
{
    public bool MotorFueraDeBorda { get; set; }
    public double GruaCapacidad { get; set; }

    public LanchaMedica(string nombre) : base(nombre)
    {
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Lancha Médica {Nombre} | Motor Fuera de Borda {MotorFueraDeBorda} | Grua {GruaCapacidad}kg | " +
            $"Flotabilidad {Flotabilidad} | Estabilidad {Estabilidad}");
    }
}