namespace Supermercado.Dominio;

public class SistemaEspera
{
    private MyQueue<Cliente> colaMayores;
    private MyQueue<Cliente> colaExcelencia;
    private MyQueue<Cliente> colaComun;

    public SistemaEspera()
    {
        colaMayores = new MyQueue<Cliente>();
        colaExcelencia = new MyQueue<Cliente>();
        colaComun = new MyQueue<Cliente>();
    }

    public void AgregarCliente(Cliente cliente)
{
    if (cliente.EsMayor)
    {
        colaMayores.Enqueue(cliente);
    }
    else if (cliente.EsExcelencia)
    {
        colaExcelencia.Enqueue(cliente);
    }
    else
    {
        colaComun.Enqueue(cliente);
    }
}


public Cliente AtenderCliente()
{
    if (!colaMayores.IsEmpty())
    {
        return colaMayores.Dequeue();
    }

    if (!colaExcelencia.IsEmpty())
    {
        return colaExcelencia.Dequeue();
    }

    if (!colaComun.IsEmpty())
    {
        return colaComun.Dequeue();
    }

    throw new InvalidOperationException("No hay clientes esperando.");
}

public void MostrarEstado()
{
    Console.WriteLine("Clientes mayores en espera: " + colaMayores.Count());
    Console.WriteLine("Clientes Excelencia en espera: " + colaExcelencia.Count());
    Console.WriteLine("Clientes comunes en espera: " + colaComun.Count());
}

public bool HayClientes()
{
    return
        !colaMayores.IsEmpty() ||
        !colaExcelencia.IsEmpty() ||
        !colaComun.IsEmpty();
}

}