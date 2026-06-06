namespace TemplateMethod.Dominio;

public class Cafe : Bebida
{
    protected override void PrepararIngrediente()
    {
        Console.WriteLine("Preparando café molido...");
    }
}