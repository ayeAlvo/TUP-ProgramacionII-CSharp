public class Guardia : Persona
{
    public override string Presentarse()
    {
        return $"Hola, mi nombre es {GetNombre()} {GetApellido()} y soy el guardia.";
    }
}