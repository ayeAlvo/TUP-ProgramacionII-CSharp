public abstract class TipoTraccion
{
    public int Autonomia { get; set; }
    public int DescuentoPotencia { get; set; }
    public string Nombre { get; set; }

    public abstract void MostrarDatos();
}