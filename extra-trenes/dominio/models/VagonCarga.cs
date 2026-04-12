namespace Trenes.Dominio.Models;

public class VagonCarga : Vagon
{
    public int CargaMaximaKg { get; }

    public override int PesoMaximo => CargaMaximaKg + 160;

    public override double Peso => PesoMaximo;

    public VagonCarga(int numero, int cargaMaximaKg) : base(numero)
    {
        CargaMaximaKg = cargaMaximaKg;
    }

    public override string Tipo => "Vagón de Carga";

    public override string ToString()
        => $"{base.ToString()} - Carga máx: {CargaMaximaKg} kg - Peso máx: {PesoMaximo} kg";
}