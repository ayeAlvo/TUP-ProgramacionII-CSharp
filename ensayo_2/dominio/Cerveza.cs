namespace AfterOffice.Dominio;

public abstract class Cerveza
{
    private string nombre;
    private double precioLitro;

    public Cerveza(string nombre, double precioLitro)
    {
         if (string.IsNullOrWhiteSpace(nombre)) // esto no funco como esperaba, no lo voy a usar
        {
            throw new Exception("El nombre no puede ser nulo o estar vacío.");
        }

        if (precioLitro <= 0)
        {
            throw new Exception("El precio por litro debe ser mayor a cero.");
        }

        this.nombre = nombre;
        this.precioLitro = precioLitro;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public double GetPrecioLitro()
    {
        return precioLitro;
    }
}