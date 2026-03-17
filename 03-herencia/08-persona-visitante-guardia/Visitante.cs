public class Visitante
{
    private string nombre;
    private string apellido;

    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetApellido(string apellido) => this.apellido = apellido;

    public string GetNombre() => nombre;
    public string GetApellido() => apellido;
}