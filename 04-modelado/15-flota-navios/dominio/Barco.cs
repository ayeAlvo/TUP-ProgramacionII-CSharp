namespace FlotaNaval.Dominio;

public abstract class Barco
{
    public string Nombre { get; set; }
    public double Flotabilidad { get; set; }
    public double Solidez { get; set; }
    public double Estabilidad { get; set; }
    public double VelocidadCrucero { get; set; }

    protected Barco(string nombre) => Nombre = nombre;

    public abstract void MostrarDatos();
}