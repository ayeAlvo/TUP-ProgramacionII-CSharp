namespace Cartas.Dominio;
public class MyStack<T>
{
    private MyNode<T>? head;
    private int count;

    public MyStack()
    {
        head = null;
        count = 0;
    }

    public void Push(T value)
    {
        var newNode = new MyNode<T>(value);

        newNode.Next = head;

        head = newNode;
        count++;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack vacio.");
        }

        T value = head!.Value;

        head = head.Next;
        count--;
        return value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public int Count()
    {
        return count;
    }
}