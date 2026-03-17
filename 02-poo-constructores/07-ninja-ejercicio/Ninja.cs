public class Ninja
{
    private string arma;
    private int fuerza;
    private int salto;

    private string arteMarcial;


    public void SetArma(string arma) => this.arma = arma;
    public void SetFuerza(int fuerza) => this.fuerza = fuerza;
    public void SetSalto(int salto) => this.salto = salto;
    public void SetArteMarcial(string arteMarcial) => this.arteMarcial = arteMarcial;


    public string GetArma() => arma;
    public int GetFuerza() => fuerza;
    public int GetSalto() => salto;
    public string GetArteMarcial() => arteMarcial;

    public void Saltar(int multiplicador)
    {
        Console.WriteLine("Salto: " + salto * multiplicador);
    }

    public void Ataque()
    {
        Console.WriteLine("Hace " + arteMarcial + " y su arma principal es: " + arma);
    }

}