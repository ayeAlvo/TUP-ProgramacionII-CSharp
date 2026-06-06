namespace TemplateMethod.Dominio;

public abstract class Bebida
{
    public void Preparar()
    {
        HervirAgua();

        PrepararIngrediente();

        Servir();
    }

    private void HervirAgua()
    {
        Console.WriteLine("Hirviendo agua...");
    }

    protected abstract void PrepararIngrediente();

    private void Servir()
    {
        Console.WriteLine("Sirviendo bebida...");
    }
}