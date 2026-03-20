public class Oruga : TipoTraccion
{
    public Oruga()
    {
        Autonomia = 400;
        DescuentoPotencia = 3;
        Nombre = "Oruga con sensores Meke-M0";
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Tipo: {Nombre}, Autonomía: {Autonomia} km, Descuento de potencia: {DescuentoPotencia} hp");
        Console.WriteLine("Incluye sensores Meke-M0 para medir temperatura.");
    }
}