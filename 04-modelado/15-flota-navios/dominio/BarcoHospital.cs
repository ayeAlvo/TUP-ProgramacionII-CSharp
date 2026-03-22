namespace FlotaNaval.Dominio;

public class BarcoHospital : Barco
{
    public int CapacidadPacientes { get; set; }

    public BarcoHospital(string nombre) : base(nombre)
    {
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Barco Hospital {Nombre} | Capacidad {CapacidadPacientes} | " +
            $"Flotabilidad {Flotabilidad} | Estabilidad {Estabilidad}");
    }
}