namespace Dominio.Balanceador;

public class Pedido
{
    public int Id { get; set; }
    public int CiclosProcesador { get; set; }
    public string Tipo { get; set; }

    public Pedido(int id, int ciclosProcesador, string tipo)
    {
        Id = id;
        CiclosProcesador = ciclosProcesador;
        Tipo = tipo;
    }

    public override string ToString()
    {
        return "Pedido " + Id + " - " + Tipo + " - " + CiclosProcesador + " ciclos";
    }
}