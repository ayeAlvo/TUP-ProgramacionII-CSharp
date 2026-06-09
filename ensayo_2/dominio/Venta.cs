namespace AfterOffice.Dominio;

public class Venta
{
    private Cerveza cerveza;
    private Vaso vaso;
    private double margenGanancia;

    public Venta(Cerveza cerveza, Vaso vaso)
    {

        if (cerveza == null) // habria que usar algo especificoo para valor null, o espacios en blanco
        {
            throw new Exception("La cerveza no puede ser nula.");
        }

        if (vaso == null)
        {
            throw new Exception("El vaso no puede ser nulo.");
        }

        this.cerveza = cerveza;
        this.vaso = vaso;
        this.margenGanancia = 1.5;
    }

    public double CalcularPrecio()
    {
        return this.cerveza.GetPrecioLitro()
            * this.margenGanancia
            * this.vaso.GetCapacidadLitros();
    }

    public string Detalle()
    {
        return this.cerveza.GetNombre()
            + " - "
            + this.vaso.GetTipo()
            + " - Precio: $"
            + this.CalcularPrecio();
    }
}