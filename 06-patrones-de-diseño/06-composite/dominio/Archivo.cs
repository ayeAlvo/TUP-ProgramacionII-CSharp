namespace Composite.Dominio;

public class Archivo : IElemento
{
    private string nombre;

    public Archivo(string nombre)
    {
        this.nombre = nombre;
    }

    public void Mostrar()
    {
        Console.WriteLine("Archivo: " + nombre);
    }
}