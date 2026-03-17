public class Fruta
{
    private string nombre;
    private string color;
    private int peso;

    private bool esEstacional;

public Fruta()
    {
    }

 public Fruta(string nombre, string color, int peso, bool esEstacional)
    {
        this.nombre = nombre;
        this.color = color;
        this.peso = peso;
        this.esEstacional = esEstacional;
    }

    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetColor(string color) => this.color = color;
    public void SetPeso(int peso) => this.peso = peso;
    public void SetEsEstacional(bool esEstacional) => this.esEstacional = esEstacional;

    public string GetNombre() => nombre;
    public string GetColor() => color;
    public int GetPeso() => peso;
    public bool GetEsEstacional() => esEstacional;


    public bool EsComestible()
    {
        return peso < 200 && esEstacional;
    }
}