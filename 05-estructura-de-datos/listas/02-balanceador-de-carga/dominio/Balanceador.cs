namespace Dominio.Balanceador;

public class Balanceador
{
    private MyList<Servidor> servidores;
    private int maxPedidosPorServidor;
    private int ultimoIdServidor;
    private Random random;

    public Balanceador(int maxPedidosPorServidor)
    {
        servidores = new MyList<Servidor>();
        this.maxPedidosPorServidor = maxPedidosPorServidor;
        ultimoIdServidor = 1;
        random = new Random();

        servidores.Push(new Servidor(ultimoIdServidor, maxPedidosPorServidor));
    }

    public void AsignarPedido(Pedido pedido)
    {
        Servidor servidor = BuscarServidorDisponible();

        servidor.RecibirPedido(pedido);

        Console.WriteLine("Pedido " + pedido.Id + " asignado a " + servidor);
    }

    private Servidor BuscarServidorDisponible()
    {
        Servidor? elegido = null;
        int menorCantidad = int.MaxValue;

        MyNode<Servidor>? aux = servidores.GetHead();

        while (aux != null)
        {
            Servidor servidor = aux.Value;

            if (servidor.HayDisponibilidad())
            {
                int pendientes = servidor.CantidadPendientes();

                if (pendientes < menorCantidad)
                {
                    menorCantidad = pendientes;
                    elegido = servidor;
                }
                else if (pendientes == menorCantidad)
                {
                    if (random.Next(2) == 0)
                    {
                        elegido = servidor;
                    }
                }
            }

            aux = aux.Next;
        }

        if (elegido == null)
        {
            elegido = CrearServidor();
        }

        return elegido;
    }

    private Servidor CrearServidor()
    {
        ultimoIdServidor++;

        Servidor nuevoServidor = new Servidor(ultimoIdServidor, maxPedidosPorServidor);

        servidores.Push(nuevoServidor);

        Console.WriteLine("Se creo el " + nuevoServidor);

        return nuevoServidor;
    }
}