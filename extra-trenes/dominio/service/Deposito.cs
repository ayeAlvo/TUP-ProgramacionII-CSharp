using Trenes.Dominio.Models;

namespace Trenes.Dominio.Services;

public class Deposito
{
    private readonly List<Formacion> _formaciones = new();
    private readonly List<Locomotora> _locomotorasDisponibles = new();
    public IReadOnlyList<Locomotora> LocomotorasDisponibles => _locomotorasDisponibles;

    public void AgregarFormacion(Formacion formacion)
    {
        _formaciones.Add(formacion);
    }

    public IEnumerable<Formacion> ObtenerTodas() => _formaciones;

    public Formacion? BuscarPorCodigo(string codigo)
        => _formaciones.FirstOrDefault(f => f.Codigo == codigo);

    // ------------------------------------
    // 7. Vagón más pesado de cada formación
    // ------------------------------------
    public List<Vagon> ObtenerVagonesMasPesados()
    {
        var resultado = new List<Vagon>();

        foreach (var f in _formaciones)
        {
            if (f.Vagones.Any())
            {
                Vagon masPesado = f.Vagones
                    .OrderByDescending(v => v.Peso)
                    .First();

                resultado.Add(masPesado);
            }
        }

        return resultado;
    }

    // ------------------------------------
    // 8. Necesita conductor experimentado
    // ------------------------------------
    public bool NecesitaConductorExperimentado()
    {
        return _formaciones.Any(f => f.EsCompleja());
    }

    // ------------------------------------
    // 9. Agregar locomotora a una formación
    // ------------------------------------
    public void AgregarLocomotoraAFormacion(string codigoFormacion)
    {
        var formacion = _formaciones.FirstOrDefault(f => f.Codigo == codigoFormacion);

        if (formacion == null)
            throw new Exception("Formación no encontrada");

        if (formacion.Estado == EstadoFormacion.EnServicio)
            return; // no intervenir si está trabajando

        if (!_locomotorasDisponibles.Any())
            throw new Exception("No hay locomotoras disponibles");

        int empujeFaltante = formacion.EmpujeFaltante;

        // Buscar locomotora adecuada
        var locomotora = _locomotorasDisponibles
            .FirstOrDefault(l => l.ArrastreUtil >= empujeFaltante);

        if (locomotora == null)
            return; // No alcanza ninguna locomotora

        formacion.AgregarLocomotora(locomotora);
        _locomotorasDisponibles.Remove(locomotora);
    }

    public void AgregarLocomotoraDisponible(Locomotora locomotora)
    {
        _locomotorasDisponibles.Add(locomotora);
    }
}