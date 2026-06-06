namespace Composite.Dominio;

public class Carpeta : IElemento
{
    private string nombre;

    private List<IElemento> elementos;

    public Carpeta(string nombre)
    {
        this.nombre = nombre;

        elementos = new List<IElemento>();
    }

    public void Agregar(IElemento elemento)
    {
        elementos.Add(elemento);
    }

    public void Mostrar()
    {
        Console.WriteLine("Carpeta: " + nombre);

        foreach (IElemento elemento in elementos)
        {
            elemento.Mostrar();
        }
    }
}