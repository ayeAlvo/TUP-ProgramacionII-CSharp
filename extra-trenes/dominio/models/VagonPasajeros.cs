namespace Trenes.Dominio.Models;

public class VagonPasajeros : Vagon
{
    public int LargoMetros { get; }
    public double AnchoUtil { get; }

    public int CantidadPasajeros =>
        AnchoUtil <= 2.5 ? LargoMetros * 8 : LargoMetros * 10;

    public override int PesoMaximo => CantidadPasajeros * 80;

    public override double Peso => PesoMaximo;

    public VagonPasajeros(int numero, int largoMetros, double anchoUtil)
        : base(numero)
    {
        LargoMetros = largoMetros;
        AnchoUtil = anchoUtil;
    }

    public override string Tipo => "Vagón de Pasajeros";

    public override string ToString()
        => $"{base.ToString()} - Capacidad: {CantidadPasajeros} pasajeros - Peso: {PesoMaximo} kg";
}