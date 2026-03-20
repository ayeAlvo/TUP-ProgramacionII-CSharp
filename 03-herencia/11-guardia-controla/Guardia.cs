public class Guardia : Persona
{
    public override string Presentarse()
    {
        return $"Hola, mi nombre es {Nombre} {Apellido} y soy el guardia.";
    }

    public string ControlarDocumento(int dni)
    {
        return $"Adelante persona con dni {dni}";
    }
}