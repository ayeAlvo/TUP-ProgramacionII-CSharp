namespace Dominio.Balanceador;

public class MyQueue<T>
{
    private MyNode<T>? first;
    private MyNode<T>? last;

    public MyQueue()
    {
        first = null;
        last = null;
    }

    public void Enqueue(T value)
    {
        var newNode = new MyNode<T>(value);

        if (IsEmpty())
        {
            first = newNode;
        }
        else
        {
            last!.Next = newNode;
        }
        last = newNode;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            return default;
        }

        T value = first!.Value;
        first = first.Next;

        if (first == null)
        {
            last = null;
        }

        return value;
    }

    public bool IsEmpty()
    {
        return first == null && last == null;
    }

}