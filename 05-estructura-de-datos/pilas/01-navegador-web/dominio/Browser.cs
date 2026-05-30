namespace Navegador.Dominio;

public class Browser
{
    private MyStack<string> history;
    private string currentUrl;

    public Browser(string initialUrl)
    {
        history = new MyStack<string>();
        currentUrl = initialUrl;
    }

    public string GetCurrentUrl()
    {
        return currentUrl;
    }

    public void Visit(string url) 
    {
        history.Push(currentUrl);
        currentUrl = url;
    }

    public string Back()
    {
        if (history.IsEmpty())
        {
            throw new InvalidOperationException("No hay páginas en el historial.");
        }

        currentUrl = history.Pop();
        return currentUrl;
    }

    public void ShowHistory()
    {
        MyStack<string> aux = new MyStack<string>();

        Console.WriteLine("Página actual: " + currentUrl);
        Console.WriteLine("Páginas anteriores:");

        while (!history.IsEmpty())
        {
            string url = history.Pop();
            Console.WriteLine(url);
            aux.Push(url);
        }

        while (!aux.IsEmpty())
        {
            history.Push(aux.Pop());
        }
    }
}