public class Guardia : Persona
{
    public override string Presentarse()
    {
        return $"Hola, mi nombre es {Nombre} {Apellido} y soy el guardia.";
    }

    public string ControlarDocumento(Visitante visitante)
    {
        return $"Adelante {visitante.Nombre} {visitante.Apellido} con dni {visitante.Dni}";
    }
}