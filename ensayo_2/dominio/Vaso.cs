namespace AfterOffice.Dominio;

public abstract class Vaso
{
    private string tipo;
    private double capacidadLitros;

    public Vaso(string tipo, double capacidadLitros)
    {
         if (string.IsNullOrWhiteSpace(tipo))
        {
            throw new Exception("El tipo no puede ser nulo o estar vacío.");
        }

        if (capacidadLitros <= 0)
        {
            throw new Exception("La capacidad del vaso debe ser mayor a cero.");
        }

        this.tipo = tipo;
        this.capacidadLitros = capacidadLitros;
    }

    public string GetTipo()
    {
        return tipo;
    }

    public double GetCapacidadLitros()
    {
        return capacidadLitros;
    }
}