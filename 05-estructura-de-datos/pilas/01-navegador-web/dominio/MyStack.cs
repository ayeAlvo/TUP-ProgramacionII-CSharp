namespace Navegador.Dominio;

public class MyStack<T>
{
    private MyNode<T>? head;

    public MyStack()
    {
        head = null;
    }

    public void Push(T value)
    {
        var newNode = new MyNode<T>(value);

        newNode.Next = head;

        head = newNode;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack vacio.");
        }

        T value = head!.Value;

        head = head.Next;

        return value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}