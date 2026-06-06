namespace TemplateMethod.Dominio;

public class Te : Bebida
{
    protected override void PrepararIngrediente()
    {
        Console.WriteLine("Preparando saquito de té...");
    }
}