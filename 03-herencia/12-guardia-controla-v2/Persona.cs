public class Persona
{
    public string Nombre { get; set;}

    public string Apellido { get; set;}

    public virtual string Presentarse()
    {
        return $"{Nombre} {Apellido}";
    }
}