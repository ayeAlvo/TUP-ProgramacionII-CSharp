namespace Supermercado.Dominio;

public class Cliente
{
    public string Nombre { get; set; }

    public bool EsMayor { get; set; }

    public bool EsExcelencia { get; set; }

    public Cliente(string nombre, bool esMayor, bool esExcelencia)
    {
        Nombre = nombre;
        EsMayor = esMayor;
        EsExcelencia = esExcelencia;
    }
}