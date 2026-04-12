namespace Trenes.Dominio.Models;

public class Formacion
{
    private readonly List<Locomotora> _locomotoras = new();
    private readonly List<Vagon> _vagones = new();

    public IReadOnlyList<Locomotora> Locomotoras => _locomotoras;
    public IReadOnlyList<Vagon> Vagones => _vagones;

    public string Codigo { get; }
    public EstadoFormacion Estado { get; private set; }

    public Formacion(string codigo)
    {
        Codigo = codigo;
        Estado = EstadoFormacion.EnDeposito;
    }

    // --------------------------
    // 1) Agregar unidades
    // --------------------------
    public void AgregarLocomotora(Locomotora locomotora)
        => _locomotoras.Add(locomotora);

    public void AgregarVagon(Vagon vagon)
        => _vagones.Add(vagon);

    public void CambiarEstado(EstadoFormacion nuevoEstado)
        => Estado = nuevoEstado;

    // --------------------------
    // 4) La formación es eficiente?
    // --------------------------
    public bool EsEficiente()
        => _locomotoras.All(l => l.ArrastreUtil >= l.Peso * 5);

    // --------------------------
    // 5) Puede moverse?
    // --------------------------
    public bool PuedeMoverse()
    => ArrastreTotal() >= PesoTotalVagones;

    // Helpers
    private int ArrastreTotal()
        => _locomotoras.Sum(l => l.ArrastreUtil);

   public int PesoTotalVagones
    => _vagones.Sum(v => v.PesoMaximo);
public int EmpujeFaltante
{
    get
    {
        int falta = PesoTotalVagones - ArrastreTotal();
        return falta > 0 ? falta : 0;
    }
}

public int CantidadUnidades => _locomotoras.Count + _vagones.Count;

public int PesoTotalFormacion
    => _locomotoras.Sum(l => l.Peso) + PesoTotalVagones;

public bool EsCompleja()
    => CantidadUnidades > 20 || PesoTotalFormacion > 10000;

    public override string ToString()
        => $"Formación {Codigo} - Locomotoras: {_locomotoras.Count} - " +
           $"Vagones: {_vagones.Count} - Estado: {Estado}";
}