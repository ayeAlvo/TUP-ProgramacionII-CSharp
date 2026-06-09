namespace AfterOffice.Dominio;

public class Barril
{
    private Cerveza cerveza;
    private double litrosDisponibles;

    public Barril(Cerveza cerveza, double litrosDisponibles)
    {
        if (cerveza == null)
        {
            throw new Exception("La cerveza no puede ser nula.");
        }

        if (litrosDisponibles <= 0)
        {
            throw new Exception("Los litros deben ser mayores a cero.");
        }

        this.cerveza = cerveza;
        this.litrosDisponibles = litrosDisponibles;
    }

    public Cerveza GetCerveza()
    {
        return cerveza;
    }

    public double GetLitrosDisponibles()
    {
        return litrosDisponibles;
    }

    public void Descontar(double litros)
    {
        if (litros > litrosDisponibles)
        {
            throw new Exception("No hay suficiente cerveza.");
        }

        litrosDisponibles -= litros;
    }
}