public class RuedaDeCaucho : TipoTraccion
{
    public RuedaDeCaucho()
    {
        Autonomia = 100;
        DescuentoPotencia = 1;
        Nombre = "Rueda de caucho";
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Tipo: {Nombre}, Autonomía: {Autonomia} km, Descuento de potencia: {DescuentoPotencia} hp");
    }
}