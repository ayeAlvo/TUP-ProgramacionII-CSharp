namespace Supermercado.Dominio;

public class MyQueue<T>
{
    private MyNode<T>? first;
    private MyNode<T>? last;
    private int count;

    public MyQueue()
    {
        first = null;
        last = null;
        count = 0;
    }

    public void Enqueue(T value)
    {
        MyNode<T> newNode = new MyNode<T>(value);

        if (IsEmpty())
        {
            first = newNode;
            last = newNode;
        }
        else
        {
            last!.Next = newNode;
            last = newNode;
        }

        count++;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cola vacia");
        }

        T value = first!.Value;
        first = first.Next;

        if (first == null)
        {
            last = null;
        }

        count--;

        return value;
    }

    public bool IsEmpty()
    {
        return first == null && last == null;
    }

    public int Count()
    {
        return count;
    }
}