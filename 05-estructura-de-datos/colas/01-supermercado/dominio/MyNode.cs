namespace Supermercado.Dominio;

public class MyNode<T>
{
    public T Value { get; set; }
    public MyNode<T>? Next { get; set; }

    public MyNode(T value)
    {
        Value = value;
        Next = null;
    }
}