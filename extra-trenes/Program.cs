using Trenes.Dominio.Models;
using Trenes.Dominio.Services;

// Crear depósito
var deposito = new Deposito();

// Crear locomotoras
var loco = new Locomotora(
    modelo: "GM GT22",
    potenciaHP: 2200,
    peso: 8000,
    pesoMaximoArrastre: 19000,
    velocidadMaxima: 75
);

var loco2 = new Locomotora(
    modelo: "GT26",
    potenciaHP: 3000,
    peso: 1000,
    pesoMaximoArrastre: 12000,
    velocidadMaxima: 80
);

// Crear formación
var f1 = new Formacion("F001");

// Agregar locomotoras a la formación
f1.AgregarLocomotora(loco);
f1.AgregarLocomotora(loco2);

// Agregar vagones
f1.AgregarVagon(new VagonPasajeros(1, 80, anchoUtil: 2));
f1.AgregarVagon(new VagonPasajeros(2, 90, anchoUtil: 3));
f1.AgregarVagon(new VagonCarga(3, 50000));   // 50.000 kg

// Cambiar estado de la formación
f1.CambiarEstado(EstadoFormacion.EnServicio);

// Guardar en depósito
deposito.AgregarFormacion(f1);

// ===============================
//   MOSTRAR FORMACIONES
// ===============================
Console.WriteLine("=== FORMACIONES EN DEPOSITO ===");
foreach (var f in deposito.ObtenerTodas())
{
    Console.WriteLine(f);
    foreach (var v in f.Vagones)
        Console.WriteLine("  - " + v);
}

// ===============================
//   PRUEBAS DE CÁLCULOS
// ===============================

Console.WriteLine("\n=== PRUEBAS ===");

// Arrastre útil individual
Console.WriteLine($"Arrastre util {loco.Modelo}: {loco.ArrastreUtil} kg");
Console.WriteLine($"Arrastre util {loco2.Modelo}: {loco2.ArrastreUtil} kg");

// Peso total de los vagones
Console.WriteLine($"Peso total vagones F001: {f1.PesoTotalVagones} kg");

// ¿Puede moverse?
Console.WriteLine($"¿La formacion puede moverse?: {f1.PuedeMoverse()}");

// ¿Es eficiente?
Console.WriteLine($"¿La formacion es eficiente?: {f1.EsEficiente()}");

// Empuje faltante
Console.WriteLine($"Empuje faltante: {f1.EmpujeFaltante} kg");

// Vagon más pesado por formación
Console.WriteLine("\n=== Vagon mas pesado por formacion ===");
foreach (var v in deposito.ObtenerVagonesMasPesados())
{
    Console.WriteLine(v);
}

Console.WriteLine("\n=== COMPLEJIDAD ===");
Console.WriteLine($"¿Formacion compleja?: {f1.EsCompleja()}");
Console.WriteLine($"¿Deposito necesita conductor experto?: {deposito.NecesitaConductorExperimentado()}");

if (!deposito.LocomotorasDisponibles.Any())
{
    deposito.AgregarLocomotoraDisponible(new Locomotora(
        "Extra1", 2500, 900, 10000, 70
    ));

    deposito.AgregarLocomotoraDisponible(new Locomotora(
        "Extra2", 2800, 1200, 15000, 85
    ));
}
