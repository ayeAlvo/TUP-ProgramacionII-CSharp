public class Persona
{
    public string Nombre { get; }
    public CelularBase Celular { get; }

    public Persona(string nombre, CelularBase celular)
    {
        Nombre = nombre;
        Celular = celular;
    }

    public void Llamar(Persona destino, double duracionMin)
    {
        if (Celular.Apagado)
        {
            Console.WriteLine($"{Nombre} no puede llamar, su celular está apagado.");
            return;
        }

        Celular.Consumir(duracionMin);
        destino.Celular.Consumir(duracionMin);
    }
}