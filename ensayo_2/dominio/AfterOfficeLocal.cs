namespace AfterOffice.Dominio;

public class AfterOfficeLocal
{
    private List<Barril> barriles;
    private List<Venta> ventas;

    public AfterOfficeLocal()
    {
        barriles = new List<Barril>();
        ventas = new List<Venta>();
    }

    public void AgregarBarril(Barril barril)
    {
        // ArgumentNullException.ThrowIfNull(barril);

        barriles.Add(barril);
    }

    public Venta RealizarVenta(Barril barril, Vaso vaso)
    {
        // ArgumentNullException.ThrowIfNull(barril);
        // ArgumentNullException.ThrowIfNull(vaso);

        double litrosNecesarios = vaso.GetCapacidadLitros();

        barril.Descontar(litrosNecesarios);

        Venta venta = new Venta(
            barril.GetCerveza(),
            vaso
        );

        ventas.Add(venta);

        return venta;
    }
}