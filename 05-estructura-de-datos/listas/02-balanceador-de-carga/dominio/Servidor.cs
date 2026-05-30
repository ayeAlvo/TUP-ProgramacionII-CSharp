namespace Dominio.Balanceador;

public class Servidor : IComparable<Servidor>
{
    public int Id { get; set; }

    private MyQueue<Pedido> pedidos;
    private int maxPedidos;
    private int cantPedidosPend;

    private int totalProcesados;
    private int totalCPU;
    private int totalES;
    private int ciclosESMasLargo;

    public Servidor(int id, int maxPedidos)
    {
        Id = id;
        this.maxPedidos = maxPedidos;
        cantPedidosPend = 0;

        totalProcesados = 0;
        totalCPU = 0;
        totalES = 0;
        ciclosESMasLargo = 0;

        pedidos = new MyQueue<Pedido>();
    }

    public bool HayDisponibilidad()
    {
        return cantPedidosPend < maxPedidos;
    }

    public int CantidadPendientes()
    {
        return cantPedidosPend;
    }

    public void RecibirPedido(Pedido pedido)
    {
        if (!HayDisponibilidad())
        {
            Console.WriteLine("Servidor " + Id + " sin disponibilidad.");
            return;
        }

        pedidos.Enqueue(pedido);
        cantPedidosPend++;
    }

    public Pedido ProcesarPedido()
    {
        Pedido pedido = pedidos.Dequeue();

        cantPedidosPend--;
        totalProcesados++;

        if (pedido.Tipo == "CPU")
        {
            totalCPU++;
        }
        else if (pedido.Tipo == "E/S")
        {
            totalES++;

            if (pedido.CiclosProcesador > ciclosESMasLargo)
            {
                ciclosESMasLargo = pedido.CiclosProcesador;
            }
        }

        return pedido;
    }

    public double PorcentajeCPU()
    {
        if (totalProcesados == 0)
        {
            return 0;
        }

        return totalCPU * 100.0 / totalProcesados;
    }

    public double PorcentajeES()
    {
        if (totalProcesados == 0)
        {
            return 0;
        }

        return totalES * 100.0 / totalProcesados;
    }

    public int TotalCPU()
    {
        return totalCPU;
    }

    public int CiclosESMasLargo()
    {
        return ciclosESMasLargo;
    }

    public int CompareTo(Servidor? otro)
    {
        return Id.CompareTo(otro!.Id);
    }

    public override string ToString()
    {
        return "Servidor " + Id;
    }
}